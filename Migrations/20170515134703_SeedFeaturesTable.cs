using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedFeaturesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make1'), (SELECT Id FROM Models WHERE Name = 'Make1-ModelA'), 'A/C')");
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make1'), (SELECT Id FROM Models WHERE Name = 'Make1-ModelB'), 'A/C')");
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make2'), (SELECT Id FROM Models WHERE Name = 'Make2-ModelA'), 'A/C')");
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make2'), (SELECT Id FROM Models WHERE Name = 'Make2-ModelC'), 'A/C')");
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make3'), (SELECT Id FROM Models WHERE Name = 'Make3-ModelA'), 'A/C')");
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make3'), (SELECT Id FROM Models WHERE Name = 'Make3-ModelA'), 'Summer Tires')");
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make3'), (SELECT Id FROM Models WHERE Name = 'Make3-ModelA'), 'Cup Holder')");
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make3'), (SELECT Id FROM Models WHERE Name = 'Make3-ModelB'), 'A/C')");
            migrationBuilder.Sql("INSERT INTO Features (MakeId, ModelId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Make3'), (SELECT Id FROM Models WHERE Name = 'Make3-ModelC'), 'A/C')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
