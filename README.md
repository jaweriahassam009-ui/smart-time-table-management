# SmartLife AI – Smart Time Table Management System

SmartLife AI is an intelligent timetable management system built with Flutter and Firebase. It helps organizations manage classes, subjects, lecturers, rooms, working days and time slots, automatically generate timetables, detect scheduling conflicts, and reduce the effort required for manual timetable planning.

## 📌 Project Overview

Creating timetables manually can be time-consuming and can lead to conflicts such as:

- A lecturer being assigned to two classes at the same time
- A classroom being occupied by multiple classes
- A class receiving multiple lectures in the same time slot
- Difficulty updating timetables when schedules change
- Repeating the same manual planning work

SmartLife AI provides a digital solution that organizes scheduling information and automatically creates a conflict-aware timetable.

## 🎯 Problem Statement

Educational institutions and other organizations often depend on manual timetable planning. This can take significant time and may result in scheduling errors.

The goal of SmartLife AI is to make timetable planning faster, more organized and easier to update.

## 💡 Proposed Solution

SmartLife AI provides a centralized timetable management system where an administrator can manage scheduling resources and generate a timetable automatically.

The system checks important constraints including:

- Class availability
- Lecturer availability
- Room availability
- Working days
- Available time slots

The generated timetable can then be reviewed and confirmed.

## ✨ Key Features

### Admin Management

The administrator can:

- Manage classes
- Manage subjects
- Manage lecturers
- Manage rooms
- Manage working days
- Manage time slots
- Generate timetables
- View previous timetables
- Confirm generated timetables
- Detect scheduling conflicts

### Lecturer Portal

Lecturers can:

- Log in securely
- Access their timetable
- View assigned subjects
- View class, room, day and time information

### Intelligent Timetable Generation

The system automatically assigns:

- Classes
- Subjects
- Lecturers
- Rooms
- Days
- Time slots

while checking for scheduling conflicts.

### Conflict Detection

The system checks for conflicts involving:

- The same class at the same time
- The same lecturer at the same time
- The same room at the same time

## 🤖 Intelligent Scheduling

SmartLife AI uses constraint-based scheduling logic to generate timetables while respecting important scheduling constraints.

The current prototype focuses on conflict-aware automated scheduling. A full Genetic Algorithm optimization approach can be added as a future enhancement.

## 🌦️ Chitral Context

The project is designed with local scheduling challenges in mind.

In areas such as Chitral, unexpected weather conditions, environmental situations and sudden holidays can disrupt planned schedules.

A digital timetable management system can make it easier to regenerate or update schedules when working days or available time slots change.

## 👥 Target Users

SmartLife AI can be useful for:

- Schools
- Colleges
- Universities
- Training centers
- Educational organizations
- Students
- Lecturers
- Working individuals who need structured schedules

## 🛠️ Technology Stack

### Frontend

- Flutter
- Dart
- Material Design

### Backend and Data

- Firebase Authentication
- Cloud Firestore
- ASP.NET Core Web API
- Microsoft SQL Server

### Development Tools

- Visual Studio Code
- Flutter SDK
- Firebase
- Git
- GitHub

## 🏗️ System Architecture

```text
User
  |
  v
Flutter Application
  |
  +--------------------+
  |                    |
  v                    v
Firebase            ASP.NET Core
Authentication      Web API
  |                    |
  v                    v
Cloud Firestore     SQL Server
