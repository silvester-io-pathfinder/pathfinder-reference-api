using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class LoreSeeder : IEntitySeed<Lore>
    {
        public IEnumerable<Lore> GetSeedEntities()
        {
            yield return new Lore { Id = Guid.Parse("a20da31f-7ed2-41a3-99e2-2105144ae00c"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Academia" };
            yield return new Lore { Id = Guid.Parse("76dc8338-d86c-40a7-8a9c-15d64006bfb4"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Accounting" };
            yield return new Lore { Id = Guid.Parse("972635f0-889d-411b-8f29-abf1ade9da18"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Architecture" };
            yield return new Lore { Id = Guid.Parse("c523fba8-bdfc-4eae-bd83-3735c421fc6c"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Art" };
            yield return new Lore { Id = Guid.Parse("3355e2fe-2868-4d57-8e78-0a6f6e7f9cd6"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Circus" };
            yield return new Lore { Id = Guid.Parse("f86f9546-665e-4a31-8f98-8162ea95add1"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Engineering" };
            yield return new Lore { Id = Guid.Parse("ecd24e93-d6b6-46a4-8866-b4292df19c11"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Farming" };
            yield return new Lore { Id = Guid.Parse("3cb1887c-28e5-4927-b40e-2b9b579126b2"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Fishing" };
            yield return new Lore { Id = Guid.Parse("1e08e096-27f7-4d62-a52a-642b87871d10"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Fortune Telling" };
            yield return new Lore { Id = Guid.Parse("59c448b6-53f8-46d4-a547-d8a7ff86d334"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Games" };
            yield return new Lore { Id = Guid.Parse("a01a140e-95a0-483e-b472-a193751f8149"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Genealogy" };
            yield return new Lore { Id = Guid.Parse("0d91d63d-082b-472e-bc07-a68d17c20f80"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Gladiatorial" };
            yield return new Lore { Id = Guid.Parse("67ef16b1-79f0-4078-870f-ea8f8c6f95c7"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Guild" };
            yield return new Lore { Id = Guid.Parse("2c700b95-816a-49a5-ac14-4d00798f1c66"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Heraldry" };
            yield return new Lore { Id = Guid.Parse("895ec4d4-9130-439b-84ca-1179973008fc"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Herbalism" };
            yield return new Lore { Id = Guid.Parse("4123ef14-b7b4-4260-ae75-67e62a136d92"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Hunting" };
            yield return new Lore { Id = Guid.Parse("9986bcde-469b-42d1-abda-135f68daa6cf"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Labor" };
            yield return new Lore { Id = Guid.Parse("10fcb507-86b4-41f1-af02-72944da5eec4"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Legal" };
            yield return new Lore { Id = Guid.Parse("f3e8b6c2-238f-4354-aa4f-f638398e851e"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Library" };
            yield return new Lore { Id = Guid.Parse("a017fa74-7dd3-4e49-b0ab-e56b53acb642"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Mercantile" };
            yield return new Lore { Id = Guid.Parse("194009eb-8f7e-4f2d-b273-116080106e16"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Midwifery" };
            yield return new Lore { Id = Guid.Parse("72e8509a-c5b4-46be-9988-607f9786626b"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Milling" };
            yield return new Lore { Id = Guid.Parse("0a92a9ed-a7b5-4b76-a011-d0c061786294"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Mining" };
            yield return new Lore { Id = Guid.Parse("efa5a63f-a6df-4e20-8834-eef62de65127"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Sailing" };
            yield return new Lore { Id = Guid.Parse("f1b92dd2-deef-4baa-b744-506ddb77f169"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Scouting" };
            yield return new Lore { Id = Guid.Parse("f68a7c82-36e8-4c6f-801a-30f996f67465"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Scribing" };
            yield return new Lore { Id = Guid.Parse("15920edf-9202-476b-8ddb-5c0950c08adc"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Stabling" };
            yield return new Lore { Id = Guid.Parse("c5ef590a-1eb9-43a4-a1e6-1521d9d47614"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Tanning" };
            yield return new Lore { Id = Guid.Parse("9fd1286f-2ce0-4fe7-9152-565db6dc7b4a"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Theater" };
            yield return new Lore { Id = Guid.Parse("e8ca8373-046b-4a64-8d17-ddcdcf56f869"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Underworld" };
            yield return new Lore { Id = Guid.Parse("2b728d17-8d3c-42fc-aa53-08e5d73debd9"), StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Warfare" };
        }
    }

    public class PlaneLoreSeeder : IEntitySeed<PlaneLore>
    {
        public IEnumerable<PlaneLore> GetSeedEntities()
        {
            foreach (Plane plane in new PlaneSeeder().GetSeedEntities())
            {
                //Reuse the plane ids.
                yield return new PlaneLore { Id = plane.Id, StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), PlaneId = plane.Id };
            }
        }
    }

    public class DeityLoreSeeder : IEntitySeed<DeityLore>
    {
        public IEnumerable<DeityLore> GetSeedEntities()
        {
            foreach (Deity deity in new DeitySeeder().GetSeedEntities())
            {
                //Reuse the deity ids.
                yield return new DeityLore { Id = deity.Id, StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), DeityId = deity.Id };
            }
        }
    }

    public class CreatureLoreSeeder : IEntitySeed<CreatureLore>
    {
        public IEnumerable<CreatureLore> GetSeedEntities()
        {
            //TODO: Creature Lore
            return Array.Empty<CreatureLore>();
        }
    }

    public class TerrainLoreSeeder : IEntitySeed<TerrainLore>
    {
        public IEnumerable<TerrainLore> GetSeedEntities()
        {
            //TODO: Terrain Lore
            return Array.Empty<TerrainLore>();
        }
    }

    public class SettlementLoreSeeder : IEntitySeed<SettlementLore>
    {
        public IEnumerable<SettlementLore> GetSeedEntities()
        {
            //TODO: Settlement Lore
            return Array.Empty<SettlementLore>();
        }
    }

    public class ConsumableLoreSeeder : IEntitySeed<ConsumableLore>
    {
        public IEnumerable<ConsumableLore> GetSeedEntities()
        {
            //TODO: Consumable Lore
            return Array.Empty<ConsumableLore>();
        }
    }
}
