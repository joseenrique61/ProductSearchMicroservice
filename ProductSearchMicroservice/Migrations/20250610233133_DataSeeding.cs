using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductSearchMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Café de origen colombiano.", "Café Premium", 4.9900000000000002 },
                    { 2, "Bluetooth 5.0 y cancelación de ruido.", "Auriculares Inalámbricos", 24.989999999999998 },
                    { 3, "Switches rojos y retroiluminación RGB.", "Teclado Mecánico", 59.990000000000002 },
                    { 4, "Diseño lumbar para largas jornadas.", "Silla Ergonómica", 129.99000000000001 },
                    { 5, "Luz blanca cálida y fría con sensor táctil.", "Lámpara LED", 15.99 },
                    { 6, "8GB RAM, 256GB SSD, Ryzen 5.", "Notebook 15.6\"", 499.99000000000001 },
                    { 7, "Compartimientos secretos y USB externo.", "Mochila Antirrobo", 34.899999999999999 },
                    { 8, "Carga rápida con doble salida.", "Batería Portátil 10000mAh", 22.5 },
                    { 9, "Mantiene frío o calor por 12 horas.", "Botella Térmica", 18.699999999999999 },
                    { 10, "Sensor óptico 7200 DPI con RGB.", "Mouse Gamer", 29.989999999999998 },
                    { 11, "De Robert C. Martin.", "Libro: Clean Architecture", 39.0 },
                    { 12, "Mayor velocidad y cobertura.", "Router Wi-Fi 6", 89.0 },
                    { 13, "Ideal para leer y consumir contenido.", "Tablet 10\"", 189.99000000000001 },
                    { 14, "Perfecta para videollamadas.", "Cámara Web HD", 49.899999999999999 },
                    { 15, "USB 3.0 de alta velocidad.", "Disco Duro Externo 1TB", 65.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");
        }
    }
}
