using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class HalfPlate : Template
    {
        public static readonly Guid ID = Guid.Parse("b19fb537-a420-4506-a444-fc9f58db5c11");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Level = 1,
                Name = "Half Plate",
                ArmorClassBonus = 5,
                Price = 1800,
                DexterityCap = 1,
                Strength = 16,
                CheckPenalty = 3,
                SpeedPenalty = 10,
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Plate.ID,
                BulkId = Bulks.Instances.ThreeBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fac46981-86cf-43fb-8baa-f2eb63dd18fb"), Type = TextBlockType.Text, Text = "Half plate consists of most of the upper body plates used in full plate, with lighter or sparser steel plate protection for the arms and legs. This provides some of the protection of full plate with greater flexibility and speed. A suit of this armor comes with an undercoat of padded armor and a pair of gauntlets." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf73b11a-17bd-4abb-a6c6-70fdec059cdc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
