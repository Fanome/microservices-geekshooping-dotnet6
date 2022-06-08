using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 2L, "Camisa", "Description Camisa do Mario", "https://static3.tcdn.com.br/img/img_prod/577735/camiseta_mario_infantil_18954327_1_20210716154503.jpg", "Camisa do Mario", 70.9m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 3L, "Camisa", "Description Camisa do Luigi", "https://images.tcdn.com.br/img/img_prod/579685/camiseta_luigi_358_1_20180215104006.jpg", "Camisa do Luigi", 50.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);
        }
    }
}
