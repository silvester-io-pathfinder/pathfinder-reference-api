using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class Breastplate : Template
    {
        public static readonly Guid ID = Guid.Parse("e376e538-e4c3-49b8-bff2-239a76012ec9");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Breastplate",
                ArmorClassBonus = 4,
                Price = 800,
                DexterityCap = 1,
                Strength = 16,
                CheckPenalty = 2,
                SpeedPenalty = 5,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Plate.ID,
                BulkId = Bulks.Instances.TwoBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4332249c-d32b-4dfe-9025-2a1f4bbb6f88"), Type = TextBlockType.Text, Text = "Though referred to as a breastplate, this type of armor consists of several pieces of plate or half-plate armor that protect the torso, chest, neck, and sometimes the hips and lower legs. It strategically grants some of the protection of plate while allowing greater flexibility and speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21de43a5-f03c-4532-b544-ce63ae29b89f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
