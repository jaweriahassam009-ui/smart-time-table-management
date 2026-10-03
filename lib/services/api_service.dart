import 'dart:convert';
import 'package:http/http.dart' as http;

class ApiService {
  // Our ASP.NET Core backend address
  static const String baseUrl = 'http://localhost:5038/api';

  // Get all users
  static Future<List<dynamic>> getUsers() async {
    final response = await http.get(
      Uri.parse('$baseUrl/Users'),
    );

    if (response.statusCode == 200) {
      return jsonDecode(response.body);
    } else {
      throw Exception(
        'Failed to load users. Status code: ${response.statusCode}',
      );
    }
  }

  // Register a new user
  static Future<Map<String, dynamic>> registerUser({
    required String name,
    required String email,
    required String password,
    required String userType,
  }) async {
    final response = await http.post(
      Uri.parse('$baseUrl/Users/register'),
      headers: {
        'Content-Type': 'application/json',
      },
      body: jsonEncode({
        'name': name,
        'email': email,
        'password': password,
        'userType': userType,
      }),
    );

    if (response.statusCode == 200) {
      return jsonDecode(response.body);
    } else {
      throw Exception(
        'Registration failed: ${response.body}',
      );
    }
  }

  // Login
  static Future<Map<String, dynamic>> loginUser({
    required String email,
    required String password,
  }) async {
    final response = await http.post(
      Uri.parse('$baseUrl/Users/login'),
      headers: {
        'Content-Type': 'application/json',
      },
      body: jsonEncode({
        'email': email,
        'password': password,
      }),
    );

    if (response.statusCode == 200) {
      return jsonDecode(response.body);
    } else {
      throw Exception(
        'Login failed: ${response.body}',
      );
    }
  }
}