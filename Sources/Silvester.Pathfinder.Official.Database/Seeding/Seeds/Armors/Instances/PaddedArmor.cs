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
    public class PaddedArmor : AbstractArmorTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Padded Armor",
                ArmorClassBonus = 1,
                Price = 20,
                DexterityCap = 3,
                Strength = 10,
                CheckPenalty = 0,
                SpeedPenalty = 0,
                ArmorCategoryId = LightArmor.ID,
                BulkId = Bulks.Instances.LightBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "This armor is simply a layer of heavy, quilted cloth, but it is sometimes used because it’s so inexpensive. Padded armor is easier to damage and destroy than other types of armor. Heavy armor comes with a padded armor undercoat included in its Price, though it loses the comfort trait when worn under heavy armor. You can wear just that padded armor undercoat to sleep in, if your heavy armor is destroyed, or when otherwise not wearing the full heavy armor. This allows you to keep the armor invested and benefit from the power of any runes on the associated heavy armor, but no one else can wear your heavy armor without the padded undercoat." };
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
