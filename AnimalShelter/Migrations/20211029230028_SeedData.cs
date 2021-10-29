using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "CreatureId", "Age", "Description", "Image", "Mythical", "Name", "Spieces" },
                values: new object[,]
                {
                    { 1, 3, "He's a very good boy!", "https://images.unsplash.com/photo-1559743404-85fb2bd372d3?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=735&q=80", "No", "Gunnar", "Dog" },
                    { 23, 2, "The absolute froofiest!", "https://images.unsplash.com/photo-1591946614720-90a587da4a36?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "No", "Mildred", "Dog" },
                    { 22, 3, "Well she's just the most adorable thing you ever saw!", "https://images.unsplash.com/photo-1611003228941-98852ba62227?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1074&q=80", "No", "Sprinkle", "Dog" },
                    { 21, 9, "Name is more of a description really.", "https://static.turbosquid.com/Preview/2014/12/10__15_52_12/Hellhound_1.jpg2737221e-11c1-450b-bc32-0e86ae7d144fZoom.jpg", "Yes", "Stench", "Hellhound" },
                    { 20, 4, "Just another cat. Same as the other ones.", "https://images.unsplash.com/photo-1543852786-1cf6624b9987?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1974&q=80", "No", "Dimetrius", "Cat" },
                    { 19, 19, "An old circus bear looking for a good home to retire in. Comes with his own ball!", "https://images.unsplash.com/photo-1530595467537-0b5996c41f2d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8YmVhcnxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60", "No", "Huggy", "Bear" },
                    { 18, 40, "Pretty territorial. Not really sure we should be selling this.", "https://static.wikia.nocookie.net/forgottenrealms/images/5/5b/Axe_beak-5e.jpg/revision/latest/scale-to-width-down/350?cb=20200917222507", "Yes", "Gwen", "Axe Beak" },
                    { 17, 56, "Twins. This one is smarter than the other one.", "https://ameliamellorsfantasticnarratograph.files.wordpress.com/2018/02/harpy2.jpg", "Yes", "Dum", "Harpy" },
                    { 16, 56, "Twins. This one is dumber than the other one.", "https://ameliamellorsfantasticnarratograph.files.wordpress.com/2018/02/harpy2.jpg", "Yes", "Dee", "Harpy" },
                    { 15, 297, "Mostly keeps to himself. Occasionally razes.", "https://images.unsplash.com/photo-1577493340887-b7bfff550145?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=640&q=80", "Yes", "Mortimer", "Dragon" },
                    { 14, 8, "What makes him mythical? Wouldn't you like to know...", "https://images.unsplash.com/photo-1517178271410-0b2a6480952f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=957&q=80", "Yes", "Sphinx", "Cat" },
                    { 24, 1, "Look, we just don't like cats ok? Please take him.", "https://images.unsplash.com/photo-1573865526739-10659fec78a5?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=715&q=80", "No", "Friskers", "Cat" },
                    { 13, 2, "He's a snuggler!", "https://images.unsplash.com/photo-1544568100-847a948585b9?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1074&q=80", "No", "Flops", "Dog" },
                    { 11, 1, "Only has three legs, but eats like he has all four!", "https://images.unsplash.com/photo-1452721226468-f95fb66ebf83?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8aGFtc3RlcnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", "No", "Wheels", "Hamster" },
                    { 10, 7, "Does not care for laser pointers.", "https://images.unsplash.com/photo-1561948955-570b270e7c36?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=601&q=80", "No", "Samantha", "Cat" },
                    { 9, 5, "Great with kids!", "https://images.unsplash.com/photo-1554692936-82776f9406db?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "No", "Sir Barkington", "Dog" },
                    { 8, 5, "Eats butterflies. Like, all the time.", "https://images.unsplash.com/photo-1526336024174-e58f5cdd8e13?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=687&q=80", "No", "Jerry", "Cat" },
                    { 7, 50, "High energy! Walks are a must!", "https://images.unsplash.com/photo-1521217155737-0d5632e9813f?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=687&q=80", "No", "Snaps", "Turtle" },
                    { 6, 400, "Self-named. Good luck.", "https://images.unsplash.com/photo-1614770596508-de1d826c3765?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NzB8fGRyYWdvbnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", "Yes", "Hotdog", "Dragon" },
                    { 5, 75, "This may actually be Tim Curry. We're not entirely sure.", "https://i.pinimg.com/564x/0a/40/7e/0a407e1fd8c113f0d29564f116f4c64a.jpg", "Yes", "Tim Curry", "Minotaur" },
                    { 4, 5, "What can we do? It's the only name he responds to.", "https://images.unsplash.com/photo-1552053831-71594a27632d?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=662&q=80", "No", "Dog", "Dog" },
                    { 3, 11, "Does not giggle. He's actually quite the jerk to be honest.", "https://images.unsplash.com/photo-1603349136288-95d87bd0a268?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=687&q=80", "No", "Mr. Gigglesworth", "Cat" },
                    { 2, 1, "D'awe!", "https://images.unsplash.com/photo-1578584099737-351780c55f69?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80", "No", "Gus", "Dog" },
                    { 12, 1, "Born on Xmas.", "https://images.unsplash.com/photo-1609260057679-1b9f08ea0dc5?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=687&q=80", "No", "Mistletoe", "Dog" },
                    { 25, 1, "Don't get too attached.", "https://images.unsplash.com/photo-1579161256825-57ba3094f057?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80", "No", "Floater", "Goldfish" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Creatures",
                keyColumn: "CreatureId",
                keyValue: 25);
        }
    }
}
