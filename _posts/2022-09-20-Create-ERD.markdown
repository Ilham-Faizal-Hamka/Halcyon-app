---
layout: post
title:  "Create ERD"
date:   2022-09-20 09:30:00 +0700
categories: ERD Diagram Database
---
![MicrosoftTeams-image (3)](https://user-images.githubusercontent.com/112837580/191153827-12b66465-d325-4236-8d30-beea8c33ec1c.png) <br>
Deskripsi :<br>
Terdapat entitas data Akun yang memiliki PK username (tiap akun memiliki username yang berbeda), dan atribut email. Entitas data Meditation memiliki PK med_id, sound, dan time. Entitas data Journal memiliki PK journal_id, FK username jurnal_date, journal_note, dan journal_title. Relasi Akun dengan Journal ialah one to many, dimana setiap satu akun bisa memiliki banyak jurnal sesuai yang diinputkan oleh user. Relasi Akun dengan Meditation adalah one to one dimana tiap satu akun akan memutar satu meditasi.
<br><br>
Tipe Data yang Digunakan pada Entitas Data Table di Database : <br>
Journal<br>
- PK journal_id (int)<br>
- FK username (char)<br>
- journal_date (date)<br>
- journal_note (text)<br>
- journal_title (text)<br>
Akun<br>
- PK username (char)<br>
- email (char)<br>
Meditation<br>
- PK med_id (int)<br>
- sound (blob)<br>
- time (time)<br>
