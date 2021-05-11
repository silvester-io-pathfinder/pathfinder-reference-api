using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class ExplorersClothing2 : AbstractArmorTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "",
                ArmorClassBonus = ,
                Price = ,
                DexterityCap = ,
                Strength= ,
                CheckPenalty = ,
                SpeedPenalty = ,
                Level = ,
                ArmorCategoryId = ArmorCategories.Instances.Unarmored.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
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
