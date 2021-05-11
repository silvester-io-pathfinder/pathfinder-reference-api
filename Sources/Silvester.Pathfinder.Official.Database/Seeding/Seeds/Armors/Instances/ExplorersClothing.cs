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
    public class ExplorersClothing : AbstractArmorTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Explorer's Clothing",
                ArmorClassBonus = 0,
                Price = 10,
                DexterityCap = 5,
                Strength= 0,
                CheckPenalty = 0,
                SpeedPenalty = 0,
                ArmorCategoryId = ArmorCategories.Instances.Unarmored.ID,
                ArmorGroupId = ArmorGroups.Instances.Cloth.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Adventurers who don’t wear armor travel in durable clothing. Though it’s not armor and uses your unarmored defense proficiency, it still has a Dex Cap and can grant an item bonus to AC if etched with potency runes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Comfort.ID;
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
