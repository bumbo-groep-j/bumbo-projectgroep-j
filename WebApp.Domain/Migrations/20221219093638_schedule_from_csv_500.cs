using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class schedulefromcsv500 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Department", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { -499, "Vers", -389, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -498, "VKK", -134, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -497, "Kassa", -193, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -496, "Vers", -447, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -495, "Vers", -190, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -494, "Vers", -92, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -493, "VKK", -361, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -492, "VKK", -11, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -491, "Vers", -307, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -490, "VKK", -148, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -489, "Vers", -291, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -488, "Vers", -43, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -487, "VKK", -477, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -486, "Vers", -468, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -485, "Vers", -387, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -484, "VKK", -465, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -483, "Vers", -157, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -482, "VKK", -7, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -481, "VKK", -284, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -480, "VKK", -268, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -479, "VKK", -374, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -478, "VKK", -458, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -477, "VKK", -201, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -476, "VKK", -28, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -475, "Vers", -491, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -474, "Vers", -400, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -473, "VKK", -178, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -472, "Kassa", -170, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -471, "VKK", -222, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -470, "Vers", -304, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -469, "Vers", -101, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -468, "VKK", -303, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -467, "Kassa", -58, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -466, "Vers", -407, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -465, "VKK", -460, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -464, "VKK", -221, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -463, "VKK", -277, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -462, "VKK", -192, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -461, "Vers", -453, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -460, "VKK", -175, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -459, "Vers", -274, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -458, "VKK", -411, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -457, "VKK", -195, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -456, "Vers", -223, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -455, "Vers", -123, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -454, "Vers", -94, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -453, "VKK", -352, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -452, "VKK", -231, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -451, "Vers", -381, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -450, "VKK", -68, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -449, "VKK", -77, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -448, "Vers", -244, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -447, "VKK", -267, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -446, "VKK", -240, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -445, "Vers", -122, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -444, "Vers", -287, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -443, "Vers", -223, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -442, "VKK", -2, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -441, "VKK", -428, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -440, "Vers", -218, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -439, "VKK", -490, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -438, "VKK", -417, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -437, "VKK", -163, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -436, "VKK", -427, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -435, "Vers", -439, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -434, "VKK", -238, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -433, "VKK", -395, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -432, "Vers", -51, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -431, "VKK", -440, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -430, "Vers", -17, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -429, "VKK", -240, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -428, "VKK", -24, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -427, "Vers", -86, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -426, "Vers", -16, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -425, "VKK", -206, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -424, "Vers", -336, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -423, "Vers", -217, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -422, "VKK", -175, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -421, "VKK", -328, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -420, "Vers", -377, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -419, "VKK", -28, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -418, "VKK", -260, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -417, "Vers", -412, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -416, "VKK", -77, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -415, "Vers", -75, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -414, "Vers", -459, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -413, "VKK", -246, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -412, "Vers", -343, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -411, "Vers", -305, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -410, "VKK", -15, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -409, "Vers", -146, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -408, "Vers", -464, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -407, "Vers", -102, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -406, "Vers", -123, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -405, "VKK", -142, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -404, "VKK", -441, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -403, "VKK", -344, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -402, "VKK", -46, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -401, "VKK", -420, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -400, "VKK", -107, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -399, "VKK", -423, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -398, "VKK", -81, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -397, "VKK", -273, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -396, "Vers", -179, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -395, "VKK", -130, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -394, "Vers", -226, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -393, "VKK", -393, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -392, "VKK", -319, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -391, "Vers", -38, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -390, "Vers", -271, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -389, "Vers", -157, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -388, "VKK", -133, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -387, "Vers", -41, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -386, "Vers", -70, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -385, "Vers", -299, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -384, "VKK", -309, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -383, "VKK", -225, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -382, "VKK", -323, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -381, "VKK", -303, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -380, "VKK", -460, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -379, "Vers", -418, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -378, "Vers", -125, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -377, "VKK", -424, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -376, "VKK", -306, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -375, "VKK", -33, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -374, "VKK", -216, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -373, "Vers", -408, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -372, "Kassa", -396, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -371, "VKK", -108, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -370, "VKK", -135, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -369, "VKK", -30, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -368, "Vers", -183, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -367, "VKK", -241, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -366, "VKK", -499, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -365, "VKK", -211, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -364, "VKK", -367, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -363, "VKK", -476, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -362, "VKK", -475, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -361, "Vers", -184, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -360, "VKK", -148, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -359, "VKK", -57, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -358, "VKK", -232, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -357, "VKK", -364, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -356, "Vers", -229, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -355, "Vers", -235, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -354, "Vers", -236, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -353, "VKK", -495, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -352, "VKK", -337, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -351, "Vers", -173, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -350, "Vers", -463, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -349, "VKK", -215, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -348, "Vers", -500, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -347, "VKK", -35, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -346, "VKK", -340, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -345, "Kassa", -429, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -344, "Vers", -50, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -343, "Vers", -200, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -342, "Vers", -257, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -341, "VKK", -30, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -340, "Vers", -349, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -339, "VKK", -433, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -338, "Kassa", -301, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -337, "VKK", -466, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -336, "Kassa", -162, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -335, "Vers", -180, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -334, "VKK", -260, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -333, "VKK", -499, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -332, "Vers", -391, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -331, "Vers", -351, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -330, "Vers", -459, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -329, "VKK", -422, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -328, "Vers", -299, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -327, "Vers", -400, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -326, "VKK", -119, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -325, "VKK", -196, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -324, "Vers", -289, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -323, "Vers", -161, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -322, "Kassa", -311, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -321, "Kassa", -390, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -320, "VKK", -420, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -319, "VKK", -234, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -318, "VKK", -357, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -317, "Vers", -93, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -316, "VKK", -441, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -315, "VKK", -10, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -314, "Vers", -343, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -313, "Vers", -305, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -312, "Vers", -249, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -311, "Vers", -386, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -310, "Vers", -482, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -309, "Vers", -137, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -308, "VKK", -6, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -307, "VKK", -90, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -306, "Vers", -335, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -305, "Vers", -227, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -304, "VKK", -145, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -303, "VKK", -294, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -302, "Vers", -157, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -301, "VKK", -403, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -300, "VKK", -374, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -299, "Vers", -462, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -298, "VKK", -375, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -297, "VKK", -362, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -296, "VKK", -264, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -295, "VKK", -266, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -294, "Vers", -166, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -293, "VKK", -82, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -292, "Vers", -481, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -291, "VKK", -136, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -290, "Vers", -474, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -289, "Vers", -204, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -288, "Vers", -376, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -287, "Vers", -21, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -286, "Vers", -144, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -285, "Kassa", -58, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -284, "VKK", -64, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -283, "VKK", -320, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -282, "Vers", -414, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -281, "VKK", -313, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -280, "VKK", -280, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -279, "Vers", -5, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -278, "VKK", -338, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -277, "Vers", -381, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -276, "VKK", -392, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -275, "Kassa", -255, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -274, "Vers", -114, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -273, "VKK", -245, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -272, "VKK", -81, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -271, "Vers", -250, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -270, "VKK", -107, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -269, "Vers", -44, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -268, "VKK", -473, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -267, "Vers", -249, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -266, "VKK", -284, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -265, "VKK", -13, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -264, "VKK", -192, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -263, "VKK", -74, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -262, "VKK", -373, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -261, "Vers", -75, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -260, "VKK", -476, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -259, "Vers", -462, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -258, "VKK", -232, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -257, "VKK", -248, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -256, "VKK", -159, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -255, "VKK", -340, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -254, "Vers", -317, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -253, "Vers", -42, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -252, "Vers", -482, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -251, "VKK", -403, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -250, "VKK", -151, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -249, "Vers", -321, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -248, "VKK", -288, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -247, "Vers", -86, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -246, "Vers", -16, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -245, "Vers", -161, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -244, "Vers", -389, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -243, "Vers", -129, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -242, "Vers", -76, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -241, "VKK", -368, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -240, "Vers", -94, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -239, "VKK", -6, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -238, "Kassa", -193, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -237, "Vers", -406, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -236, "VKK", -73, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -235, "Vers", -153, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -234, "VKK", -136, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -233, "Kassa", -177, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -232, "VKK", -27, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -231, "VKK", -384, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -230, "Vers", -446, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -229, "Vers", -106, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -228, "VKK", -499, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -227, "VKK", -134, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -226, "VKK", -195, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -225, "Vers", -3, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -224, "Vers", -198, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -223, "VKK", -332, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -222, "VKK", -410, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -221, "VKK", -303, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -220, "Vers", -132, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -219, "VKK", -382, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -218, "VKK", -63, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -217, "Kassa", -18, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -216, "VKK", -149, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -215, "Kassa", -58, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -214, "Vers", -325, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -213, "Vers", -492, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -212, "VKK", -385, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -211, "Vers", -419, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -210, "VKK", -142, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -209, "Vers", -455, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -208, "VKK", -285, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -207, "Vers", -9, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -206, "Vers", -209, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -205, "Vers", -350, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -204, "VKK", -11, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -203, "VKK", -415, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -202, "Vers", -218, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -201, "VKK", -374, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -200, "Vers", -376, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -199, "VKK", -445, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -198, "VKK", -115, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -197, "Vers", -229, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -196, "VKK", -375, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -195, "VKK", -36, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -194, "VKK", -119, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -193, "Vers", -491, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -192, "Vers", -184, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -191, "Vers", -329, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -190, "Vers", -434, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -189, "VKK", -127, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -188, "VKK", -156, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -187, "Vers", -480, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -186, "Vers", -1, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -185, "VKK", -486, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -184, "VKK", -6, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -183, "VKK", -431, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -182, "Vers", -404, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -181, "VKK", -73, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -180, "VKK", -306, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -179, "VKK", -374, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -178, "VKK", -222, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -177, "Vers", -227, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -176, "VKK", -66, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -175, "VKK", -159, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -174, "VKK", -484, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -173, "Vers", -389, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -172, "VKK", -392, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -171, "VKK", -384, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -170, "VKK", -460, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -169, "VKK", -205, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -168, "VKK", -268, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -167, "Vers", -360, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -166, "Vers", -109, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -165, "VKK", -158, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -164, "VKK", -359, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -163, "VKK", -163, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -162, "Vers", -59, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -161, "Vers", -72, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -160, "VKK", -33, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -159, "Vers", -464, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -158, "VKK", -264, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -157, "VKK", -269, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -156, "Vers", -173, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -155, "Vers", -190, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -154, "VKK", -224, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -153, "VKK", -176, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -152, "VKK", -240, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -151, "VKK", -68, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -150, "VKK", -234, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -149, "VKK", -479, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -148, "Vers", -419, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -147, "Vers", -166, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -146, "Vers", -189, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -145, "VKK", -340, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -144, "VKK", -422, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -143, "VKK", -10, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -142, "VKK", -342, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -141, "VKK", -369, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -140, "VKK", -78, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -139, "Vers", -346, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -138, "Vers", -334, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -137, "Vers", -217, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -136, "Vers", -155, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -135, "VKK", -40, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -134, "Vers", -394, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -133, "Vers", -184, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -132, "VKK", -326, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -131, "VKK", -365, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -130, "Vers", -275, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -129, "VKK", -28, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -128, "Kassa", -255, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -127, "Vers", -432, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -126, "VKK", -379, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -125, "VKK", -280, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -124, "VKK", -420, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -123, "Vers", -304, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -122, "VKK", -472, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -121, "VKK", -487, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -120, "VKK", -370, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -119, "VKK", -49, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -118, "VKK", -428, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -117, "Vers", -200, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -116, "VKK", -11, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -115, "Vers", -492, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -114, "VKK", -120, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -113, "VKK", -90, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -112, "Vers", -204, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -111, "VKK", -7, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -110, "VKK", -277, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -109, "VKK", -320, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -108, "Vers", -329, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -107, "VKK", -99, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -106, "VKK", -448, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -105, "VKK", -279, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -104, "Vers", -335, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -103, "Vers", -137, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -102, "Vers", -388, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -101, "Vers", -118, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -100, "Vers", -289, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -99, "VKK", -423, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -98, "VKK", -12, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -97, "Vers", -251, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -96, "VKK", -246, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -95, "Vers", -233, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -94, "VKK", -443, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -93, "VKK", -426, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -92, "VKK", -133, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -91, "VKK", -284, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -90, "VKK", -361, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -89, "VKK", -134, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -88, "Kassa", -37, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -87, "Vers", -122, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -86, "VKK", -156, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -85, "VKK", -234, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -84, "VKK", -259, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -83, "VKK", -375, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -82, "Vers", -421, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -81, "Vers", -236, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -80, "VKK", -6, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -79, "Vers", -209, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -78, "VKK", -206, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -77, "VKK", -215, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -76, "VKK", -25, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -75, "VKK", -402, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -74, "Vers", -356, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -73, "VKK", -33, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -72, "VKK", -239, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -71, "VKK", -169, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -70, "VKK", -224, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -69, "VKK", -306, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -68, "Vers", -354, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -67, "Vers", -43, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -66, "VKK", -163, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -65, "VKK", -15, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -64, "Vers", -125, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -63, "Vers", -452, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -62, "Vers", -217, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -61, "Kassa", -104, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -60, "Vers", -459, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -59, "Vers", -51, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -58, "VKK", -142, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -57, "VKK", -24, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -56, "Vers", -290, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -55, "VKK", -252, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -54, "VKK", -201, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -53, "VKK", -277, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -52, "VKK", -475, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -51, "Vers", -128, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -50, "VKK", -14, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -49, "Vers", -298, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -48, "VKK", -214, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -47, "VKK", -119, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -46, "Kassa", -255, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -45, "VKK", -430, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -44, "VKK", -288, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -43, "Vers", -3, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -42, "VKK", -164, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -41, "VKK", -324, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -40, "Vers", -110, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -39, "VKK", -490, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -38, "Vers", -98, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -37, "VKK", -477, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -36, "Vers", -468, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -35, "VKK", -49, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -34, "VKK", -154, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -33, "VKK", -45, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -32, "VKK", -486, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -31, "VKK", -96, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -30, "VKK", -365, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -29, "Vers", -182, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -28, "Vers", -38, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -27, "VKK", -176, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -26, "VKK", -297, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -25, "VKK", -435, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -24, "Vers", -437, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -23, "VKK", -457, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -22, "VKK", -460, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -21, "VKK", -495, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -20, "VKK", -241, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -19, "Vers", -432, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -18, "Vers", -198, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -17, "VKK", -194, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -16, "VKK", -357, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -15, "Vers", -414, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -14, "Vers", -228, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -13, "VKK", -261, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -12, "VKK", -78, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -11, "Vers", -376, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -10, "VKK", -57, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -9, "VKK", -487, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -8, "Vers", -92, new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -7, "Vers", -155, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -6, "Vers", -500, new DateTime(2022, 12, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -5, "VKK", -373, new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -4, "Vers", -114, new DateTime(2022, 12, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { -3, "VKK", -295, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -2, "VKK", -313, new DateTime(2022, 12, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { -1, "VKK", -152, new DateTime(2022, 12, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -499);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -498);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -497);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -496);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -495);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -494);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -493);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -492);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -491);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -490);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -489);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -488);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -487);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -486);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -485);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -484);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -483);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -482);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -481);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -480);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -479);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -478);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -477);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -476);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -475);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -474);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -473);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -472);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -471);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -470);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -469);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -468);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -467);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -466);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -465);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -464);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -463);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -462);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -461);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -460);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -459);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -458);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -457);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -456);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -455);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -454);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -453);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -452);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -451);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -450);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -449);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -448);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -447);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -446);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -445);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -444);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -443);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -442);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -441);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -440);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -439);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -438);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -437);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -436);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -435);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -434);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -433);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -432);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -431);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -430);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -429);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -428);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -427);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -426);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -425);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -424);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -423);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -422);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -421);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -420);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -419);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -418);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -417);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -416);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -415);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -414);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -413);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -412);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -411);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -410);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -409);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -408);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -407);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -406);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -405);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -404);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -403);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -402);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -401);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -400);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -399);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -398);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -397);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -396);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -395);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -394);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -393);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -392);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -391);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -390);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -389);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -388);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -387);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -386);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -385);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -384);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -383);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -382);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -381);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -380);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -379);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -378);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -377);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -376);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -375);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -374);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -373);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -372);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -371);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -370);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -369);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -368);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -367);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -366);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -365);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -364);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -363);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -362);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -361);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -360);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -359);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -358);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -357);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -356);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -355);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -354);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -353);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -352);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -351);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -350);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -349);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -348);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -347);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -346);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -345);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -344);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -343);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -342);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -341);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -340);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -339);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -338);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -337);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -336);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -335);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -334);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -333);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -332);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -331);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -330);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -329);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -328);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -327);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -326);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -325);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -324);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -323);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -322);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -321);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -320);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -319);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -318);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -317);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -316);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -315);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -314);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -313);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -312);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -311);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -310);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -309);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -308);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -307);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -306);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -305);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -304);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -303);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -302);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -301);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -300);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -299);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -298);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -297);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -296);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -295);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -294);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -293);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -292);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -291);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -290);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -289);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -288);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -287);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -286);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -285);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -284);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -283);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -282);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -281);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -280);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -279);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -278);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -277);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -276);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
