﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class workedhoursfromcsv500 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkedHours",
                columns: new[] { "Id", "ApprovalTime", "ApprovedTimeEnd", "ApprovedTimeStart", "ClockedTimeEnd", "ClockedTimeStart", "Department", "ScheduleId" },
                values: new object[,]
                {
                    { -499, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -173 },
                    { -498, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -89 },
                    { -497, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -238 },
                    { -496, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -496 },
                    { -495, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -155 },
                    { -494, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -8 },
                    { -493, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -90 },
                    { -492, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -116 },
                    { -491, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -491 },
                    { -490, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -360 },
                    { -489, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -489 },
                    { -488, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -67 },
                    { -487, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -37 },
                    { -486, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -36 },
                    { -485, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -485 },
                    { -484, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -484 },
                    { -483, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -302 },
                    { -482, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -111 },
                    { -481, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -91 },
                    { -480, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -168 },
                    { -479, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -179 },
                    { -478, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -478 },
                    { -477, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -54 },
                    { -476, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -129 },
                    { -475, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -193 },
                    { -474, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -327 },
                    { -473, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -473 },
                    { -472, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -472 },
                    { -471, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -178 },
                    { -470, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -123 },
                    { -469, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -469 },
                    { -468, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -221 },
                    { -467, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -215 },
                    { -466, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -466 },
                    { -465, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -22 },
                    { -464, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -464 },
                    { -463, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -53 },
                    { -462, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -264 },
                    { -461, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -461 },
                    { -460, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -422 },
                    { -459, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -459 },
                    { -458, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -458 },
                    { -457, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -226 },
                    { -456, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -443 },
                    { -455, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -406 },
                    { -454, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -240 },
                    { -453, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -453 },
                    { -452, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -452 },
                    { -451, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -277 },
                    { -450, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -151 },
                    { -449, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -416 },
                    { -448, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -448 },
                    { -447, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -447 },
                    { -446, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -152 },
                    { -445, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -87 },
                    { -444, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -444 },
                    { -443, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -443 },
                    { -442, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -442 },
                    { -441, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -118 },
                    { -440, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -202 },
                    { -439, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -39 },
                    { -438, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -438 },
                    { -437, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -66 },
                    { -436, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -436 },
                    { -435, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -435 },
                    { -434, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -434 },
                    { -433, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -433 },
                    { -432, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -59 },
                    { -431, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -431 },
                    { -430, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -430 },
                    { -429, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -152 },
                    { -428, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -57 },
                    { -427, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -247 },
                    { -426, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -246 },
                    { -425, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -78 },
                    { -424, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -424 },
                    { -423, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -62 },
                    { -422, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -422 },
                    { -421, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -421 },
                    { -420, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -420 },
                    { -419, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -129 },
                    { -418, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -334 },
                    { -417, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -417 },
                    { -416, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -416 },
                    { -415, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -261 },
                    { -414, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -60 },
                    { -413, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -96 },
                    { -412, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -314 },
                    { -411, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -313 },
                    { -410, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -65 },
                    { -409, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -409 },
                    { -408, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -159 },
                    { -407, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -407 },
                    { -406, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -406 },
                    { -405, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -58 },
                    { -404, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -316 },
                    { -403, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -403 },
                    { -402, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -402 },
                    { -401, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -124 },
                    { -400, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -270 },
                    { -399, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -99 },
                    { -398, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -272 },
                    { -397, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -397 },
                    { -396, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -396 },
                    { -395, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -395 },
                    { -394, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -394 },
                    { -393, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -393 },
                    { -392, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -392 },
                    { -391, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -28 },
                    { -390, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -390 },
                    { -389, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -302 },
                    { -388, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -92 },
                    { -387, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -387 },
                    { -386, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -386 },
                    { -385, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -328 },
                    { -384, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -384 },
                    { -383, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -383 },
                    { -382, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -382 },
                    { -381, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -221 },
                    { -380, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -22 },
                    { -379, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -379 },
                    { -378, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -64 },
                    { -377, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -377 },
                    { -376, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -69 },
                    { -375, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -73 },
                    { -374, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -374 },
                    { -373, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -373 },
                    { -372, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -372 },
                    { -371, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -371 },
                    { -370, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -370 },
                    { -369, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -341 },
                    { -368, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -368 },
                    { -367, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -20 },
                    { -366, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -228 },
                    { -365, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -365 },
                    { -364, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -364 },
                    { -363, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -260 },
                    { -362, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -52 },
                    { -361, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -133 },
                    { -360, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -360 },
                    { -359, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -10 },
                    { -358, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -258 },
                    { -357, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -357 },
                    { -356, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -197 },
                    { -355, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -355 },
                    { -354, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -81 },
                    { -353, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -21 },
                    { -352, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -352 },
                    { -351, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -156 },
                    { -350, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -350 },
                    { -349, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -77 },
                    { -348, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -6 },
                    { -347, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -347 },
                    { -346, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -145 },
                    { -345, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -345 },
                    { -344, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -344 },
                    { -343, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -117 },
                    { -342, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -342 },
                    { -341, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -341 },
                    { -340, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -340 },
                    { -339, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -339 },
                    { -338, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -338 },
                    { -337, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -337 },
                    { -336, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -336 },
                    { -335, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -335 },
                    { -334, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -334 },
                    { -333, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -228 },
                    { -332, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -332 },
                    { -331, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -331 },
                    { -330, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -60 },
                    { -329, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -144 },
                    { -328, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -328 },
                    { -327, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -327 },
                    { -326, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -47 },
                    { -325, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -325 },
                    { -324, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -100 },
                    { -323, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -245 },
                    { -322, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Kassa", -322 },
                    { -321, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -321 },
                    { -320, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -124 },
                    { -319, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -85 },
                    { -318, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -16 },
                    { -317, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -317 },
                    { -316, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -316 },
                    { -315, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -143 },
                    { -314, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -314 },
                    { -313, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -313 },
                    { -312, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -267 },
                    { -311, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -311 },
                    { -310, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -252 },
                    { -309, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -103 },
                    { -308, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -80 },
                    { -307, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -113 },
                    { -306, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -104 },
                    { -305, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -177 },
                    { -304, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -304 },
                    { -303, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -303 },
                    { -302, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -302 },
                    { -301, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -251 },
                    { -300, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -179 },
                    { -299, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -259 },
                    { -298, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -83 },
                    { -297, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -297 },
                    { -296, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -158 },
                    { -295, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -295 },
                    { -294, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -147 },
                    { -293, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -293 },
                    { -292, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -292 },
                    { -291, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -234 },
                    { -290, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -290 },
                    { -289, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -112 },
                    { -288, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -11 },
                    { -287, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -287 },
                    { -286, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -286 },
                    { -285, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Kassa", -215 },
                    { -284, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -284 },
                    { -283, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -109 },
                    { -282, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -15 },
                    { -281, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -2 },
                    { -280, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -125 },
                    { -279, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -279 },
                    { -278, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -278 },
                    { -277, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -277 },
                    { -276, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -172 },
                    { -275, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -46 },
                    { -274, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -4 },
                    { -273, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -273 },
                    { -272, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -272 },
                    { -271, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -271 },
                    { -270, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -270 },
                    { -269, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -269 },
                    { -268, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -268 },
                    { -267, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -267 },
                    { -266, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -91 },
                    { -265, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -265 },
                    { -264, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -264 },
                    { -263, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -263 },
                    { -262, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -5 },
                    { -261, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -261 },
                    { -260, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -260 },
                    { -259, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -259 },
                    { -258, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -258 },
                    { -257, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -257 },
                    { -256, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -175 },
                    { -255, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -145 },
                    { -254, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -254 },
                    { -253, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -253 },
                    { -252, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -252 },
                    { -251, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -251 },
                    { -250, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -250 },
                    { -249, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -249 },
                    { -248, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -44 },
                    { -247, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -247 },
                    { -246, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -246 },
                    { -245, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -245 },
                    { -244, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -173 },
                    { -243, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -243 },
                    { -242, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -242 },
                    { -241, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -241 },
                    { -240, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -240 },
                    { -239, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -80 },
                    { -238, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -238 },
                    { -237, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -237 },
                    { -236, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -181 },
                    { -235, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -235 },
                    { -234, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -234 },
                    { -233, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -233 },
                    { -232, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -232 },
                    { -231, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -171 },
                    { -230, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -230 },
                    { -229, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -229 },
                    { -228, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -228 },
                    { -227, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -89 },
                    { -226, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -226 },
                    { -225, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -43 },
                    { -224, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -18 },
                    { -223, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -223 },
                    { -222, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -222 },
                    { -221, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -221 },
                    { -220, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -220 },
                    { -219, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -219 },
                    { -218, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -218 },
                    { -217, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -217 },
                    { -216, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -216 },
                    { -215, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Kassa", -215 },
                    { -214, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -214 },
                    { -213, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -115 },
                    { -212, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -212 },
                    { -211, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -148 },
                    { -210, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -58 },
                    { -209, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -209 },
                    { -208, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -208 },
                    { -207, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -207 },
                    { -206, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -79 },
                    { -205, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -205 },
                    { -204, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -116 },
                    { -203, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -203 },
                    { -202, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -202 },
                    { -201, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -179 },
                    { -200, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -11 },
                    { -199, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -199 },
                    { -198, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -198 },
                    { -197, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -197 },
                    { -196, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -83 },
                    { -195, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -195 },
                    { -194, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -47 },
                    { -193, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -193 },
                    { -192, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -133 },
                    { -191, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -108 },
                    { -190, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -190 },
                    { -189, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -189 },
                    { -188, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -86 },
                    { -187, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -187 },
                    { -186, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -186 },
                    { -185, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -32 },
                    { -184, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -80 },
                    { -183, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -183 },
                    { -182, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -182 },
                    { -181, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -181 },
                    { -180, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -69 },
                    { -179, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -179 },
                    { -178, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -178 },
                    { -177, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -177 },
                    { -176, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -176 },
                    { -175, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -175 },
                    { -174, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -174 },
                    { -173, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -173 },
                    { -172, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -172 },
                    { -171, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -171 },
                    { -170, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -22 },
                    { -169, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -169 },
                    { -168, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -168 },
                    { -167, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -167 },
                    { -166, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -166 },
                    { -165, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -165 },
                    { -164, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -164 },
                    { -163, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -66 },
                    { -162, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -162 },
                    { -161, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -161 },
                    { -160, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -73 },
                    { -159, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -159 },
                    { -158, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -158 },
                    { -157, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -157 },
                    { -156, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -156 },
                    { -155, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -155 },
                    { -154, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -70 },
                    { -153, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -27 },
                    { -152, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -152 },
                    { -151, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -151 },
                    { -150, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -85 },
                    { -149, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -149 },
                    { -148, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -148 },
                    { -147, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -147 },
                    { -146, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -146 },
                    { -145, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -145 },
                    { -144, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -144 },
                    { -143, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -143 },
                    { -142, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -142 },
                    { -141, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -141 },
                    { -140, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -12 },
                    { -139, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -139 },
                    { -138, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -138 },
                    { -137, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -62 },
                    { -136, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -7 },
                    { -135, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -135 },
                    { -134, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -134 },
                    { -133, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -133 },
                    { -132, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -132 },
                    { -131, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -30 },
                    { -130, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -130 },
                    { -129, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -129 },
                    { -128, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -46 },
                    { -127, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -19 },
                    { -126, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -126 },
                    { -125, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -125 },
                    { -124, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -124 },
                    { -123, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -123 },
                    { -122, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -122 },
                    { -121, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -9 },
                    { -120, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -120 },
                    { -119, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -35 },
                    { -118, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -118 },
                    { -117, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -117 },
                    { -116, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -116 },
                    { -115, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -115 },
                    { -114, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -114 },
                    { -113, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -113 },
                    { -112, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -112 },
                    { -111, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -111 },
                    { -110, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -53 },
                    { -109, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -109 },
                    { -108, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -108 },
                    { -107, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -107 },
                    { -106, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -106 },
                    { -105, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -105 },
                    { -104, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -104 },
                    { -103, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -103 },
                    { -102, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -102 },
                    { -101, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -101 },
                    { -100, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -100 },
                    { -99, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -99 },
                    { -98, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -98 },
                    { -97, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -97 },
                    { -96, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -96 },
                    { -95, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -95 },
                    { -94, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -94 },
                    { -93, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -93 },
                    { -92, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -92 },
                    { -91, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -91 },
                    { -90, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -90 },
                    { -89, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -89 },
                    { -88, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -88 },
                    { -87, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -87 },
                    { -86, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -86 },
                    { -85, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -85 },
                    { -84, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -84 },
                    { -83, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -83 },
                    { -82, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -82 },
                    { -81, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -81 },
                    { -80, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -80 },
                    { -79, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -79 },
                    { -78, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -78 },
                    { -77, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -77 },
                    { -76, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -76 },
                    { -75, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -75 },
                    { -74, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -74 },
                    { -73, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -73 },
                    { -72, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -72 },
                    { -71, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -71 },
                    { -70, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -70 },
                    { -69, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -69 },
                    { -68, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -68 },
                    { -67, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -67 },
                    { -66, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -66 },
                    { -65, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -65 },
                    { -64, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -64 },
                    { -63, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -63 },
                    { -62, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -62 },
                    { -61, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -61 },
                    { -60, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -60 },
                    { -59, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -59 },
                    { -58, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -58 },
                    { -57, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -57 },
                    { -56, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -56 },
                    { -55, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -55 },
                    { -54, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -54 },
                    { -53, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -53 },
                    { -52, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -52 },
                    { -51, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -51 },
                    { -50, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -50 },
                    { -49, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -49 },
                    { -48, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -48 },
                    { -47, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -47 },
                    { -46, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", -46 },
                    { -45, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -45 },
                    { -44, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -44 },
                    { -43, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -43 },
                    { -42, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -42 },
                    { -41, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -41 },
                    { -40, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -40 },
                    { -39, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -39 },
                    { -38, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -38 },
                    { -37, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -37 },
                    { -36, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -36 },
                    { -35, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -35 },
                    { -34, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -34 },
                    { -33, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -33 },
                    { -32, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -32 },
                    { -31, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -31 },
                    { -30, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -30 },
                    { -29, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -29 },
                    { -28, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -28 },
                    { -27, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -27 },
                    { -26, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -26 },
                    { -25, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -25 },
                    { -24, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -24 },
                    { -23, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -23 },
                    { -22, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -22 },
                    { -21, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -21 },
                    { -20, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -20 },
                    { -19, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -19 },
                    { -18, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -18 },
                    { -17, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -17 },
                    { -16, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -16 },
                    { -15, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -15 },
                    { -14, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -14 },
                    { -13, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -13 },
                    { -12, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -12 },
                    { -11, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -11 },
                    { -10, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "VKK", -10 },
                    { -9, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -9 },
                    { -8, null, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -8 },
                    { -7, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -7 },
                    { -6, null, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Vers", -6 },
                    { -5, null, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -5 },
                    { -4, null, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), "Vers", -4 },
                    { -3, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -3 },
                    { -2, null, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -2 },
                    { -1, null, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), "VKK", -1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -499);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -498);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -497);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -496);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -495);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -494);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -493);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -492);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -491);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -490);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -489);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -488);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -487);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -486);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -485);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -484);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -483);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -482);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -481);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -480);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -479);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -478);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -477);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -476);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -475);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -474);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -473);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -472);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -471);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -470);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -469);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -468);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -467);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -466);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -465);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -464);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -463);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -462);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -461);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -460);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -459);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -458);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -457);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -456);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -455);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -454);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -453);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -452);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -451);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -450);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -449);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -448);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -447);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -446);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -445);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -444);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -443);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -442);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -441);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -440);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -439);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -438);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -437);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -436);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -435);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -434);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -433);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -432);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -431);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -430);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -429);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -428);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -427);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -426);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -425);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -424);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -423);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -422);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -421);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -420);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -419);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -418);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -417);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -416);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -415);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -414);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -413);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -412);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -411);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -410);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -409);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -408);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -407);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -406);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -405);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -404);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -403);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -402);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -401);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -400);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -399);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -398);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -397);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -396);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -395);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -394);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -393);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -392);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -391);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -390);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -389);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -388);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -387);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -386);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -385);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -384);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -383);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -382);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -381);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -380);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -379);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -378);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -377);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -376);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -375);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -374);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -373);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -372);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -371);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -370);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -369);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -368);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -367);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -366);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -365);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -364);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -363);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -362);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -361);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -360);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -359);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -358);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -357);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -356);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -355);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -354);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -353);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -352);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -351);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -350);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -349);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -348);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -347);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -346);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -345);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -344);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -343);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -342);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -341);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -340);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -339);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -338);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -337);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -336);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -335);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -334);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -333);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -332);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -331);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -330);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -329);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -328);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -327);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -326);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -325);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -324);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -323);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -322);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -321);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -320);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -319);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -318);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -317);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -316);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -315);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -314);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -313);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -312);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -311);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -310);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -309);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -308);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -307);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -306);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -305);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -304);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -303);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -302);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -301);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -300);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -299);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -298);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -297);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -296);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -295);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -294);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -293);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -292);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -291);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -290);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -289);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -288);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -287);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -286);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -285);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -284);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -283);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -282);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -281);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -280);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -279);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -278);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -277);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -276);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}