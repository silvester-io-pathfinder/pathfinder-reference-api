using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class LeatherArmor : AbstractArmorTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Leather Armor",
                ArmorClassBonus = 1,
                Price = 200,
                DexterityCap = 4,
                Strength= 10,
                CheckPenalty = 1,
                SpeedPenalty = 0,
                ArmorCategoryId = LightArmor.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A mix of flexible and molded boiled leather, a suit of this type of armor provides some protection with maximum flexibility." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
