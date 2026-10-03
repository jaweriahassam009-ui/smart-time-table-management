import 'package:flutter/material.dart';

class DashboardPage extends StatelessWidget {
final String userName;

const DashboardPage({
super.key,
required this.userName,
});

@override
Widget build(BuildContext context) {
return Scaffold(
appBar: AppBar(
title: const Text(
'SmartLife AI',
style: TextStyle(
fontWeight: FontWeight.bold,
),
),
actions: [
IconButton(
onPressed: () {},
icon: const Icon(Icons.notifications_outlined),
),
IconButton(
onPressed: () {},
icon: const Icon(Icons.account_circle_outlined),
),
],
),
body: SingleChildScrollView(
padding: const EdgeInsets.all(20),
child: Column(
crossAxisAlignment: CrossAxisAlignment.start,
children: [
Text(
'Welcome, $userName!',
style: const TextStyle(
fontSize: 28,
fontWeight: FontWeight.bold,
),
),
const SizedBox(height: 8),
const Text(
'What would you like to plan today?',
style: TextStyle(
fontSize: 16,
color: Colors.grey,
),
),
const SizedBox(height: 30),
Card(
elevation: 3,
child: Padding(
padding: const EdgeInsets.all(20),
child: Column(
crossAxisAlignment: CrossAxisAlignment.start,
children: [
const Icon(
Icons.auto_awesome,
size: 45,
color: Colors.blue,
),
const SizedBox(height: 15),
const Text(
'AI Smart Planner',
style: TextStyle(
fontSize: 22,
fontWeight: FontWeight.bold,
),
),
const SizedBox(height: 8),
const Text(
'Tell AI what you need to schedule and '
'SmartLife AI will help organize it for you.',
style: TextStyle(
fontSize: 15,
color: Colors.grey,
),
),
const SizedBox(height: 18),
SizedBox(
width: double.infinity,
child: ElevatedButton.icon(
onPressed: () {},
icon: const Icon(Icons.auto_awesome),
label: const Text('Create Smart Plan'),
),
),
],
),
),
),
const SizedBox(height: 25),
const Text(
'Quick Options',
style: TextStyle(
fontSize: 22,
fontWeight: FontWeight.bold,
),
),
const SizedBox(height: 15),
Row(
children: [
Expanded(
child: _optionCard(
icon: Icons.calendar_month,
title: 'Timetable',
),
),
const SizedBox(width: 15),
Expanded(
child: _optionCard(
icon: Icons.school,
title: 'Study Plan',
),
),
],
),
const SizedBox(height: 15),
Row(
children: [
Expanded(
child: _optionCard(
icon: Icons.event_note,
title: 'Exams',
),
),
const SizedBox(width: 15),
Expanded(
child: _optionCard(
icon: Icons.edit_calendar,
title: 'My Plans',
),
),
],
),
const SizedBox(height: 30),
const Text(
"Today's Schedule",
style: TextStyle(
fontSize: 22,
fontWeight: FontWeight.bold,
),
),
const SizedBox(height: 15),
Card(
child: ListTile(
leading: const CircleAvatar(
child: Icon(Icons.calendar_today),
),
title: const Text(
'No schedule yet',
),
subtitle: const Text(
'Create your first smart plan to see your schedule here.',
),
),
),
],
),
),
);
}

Widget _optionCard({
required IconData icon,
required String title,
}) {
return Card(
elevation: 2,
child: Padding(
padding: const EdgeInsets.all(18),
child: Column(
children: [
Icon(
icon,
size: 40,
color: Colors.blue,
),
const SizedBox(height: 10),
Text(
title,
textAlign: TextAlign.center,
style: const TextStyle(
fontSize: 16,
fontWeight: FontWeight.bold,
),
),
],
),
),
);
}
}
