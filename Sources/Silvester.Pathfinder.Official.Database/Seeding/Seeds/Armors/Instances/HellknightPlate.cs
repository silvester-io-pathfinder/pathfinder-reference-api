using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class HellknightPlate : Template
    {
        public static readonly Guid ID = Guid.Parse("abee6439-3461-45f5-b234-8e155921fc95");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Level = 2,
                Name = "Hellknight Plate",
                ArmorClassBonus = 6,
                Price = 3500,
                DexterityCap = 0,
                Strength = 18,
                CheckPenalty = 3,
                SpeedPenalty = 10,
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Plate.ID,
                BulkId = Bulks.Instances.FourBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6c2f2ed3-13f6-4efe-be8c-70b921cd99e6"), Type = TextBlockType.Text, Text = "A character who is a member of the Hellknights has access to this uncommon armor." };
            yield return new TextBlock { Id = Guid.Parse("a86ab0c4-63d1-4ec2-891b-f308291731a5"), Type = TextBlockType.Text, Text = "Few armors in the Inner Sea region are as memorable as the iconic Hellknight plate. While each order has its own flourishes, Hellknight plate is instantly recognizable to any who know of the Hellknights. Hellknights go to extreme measures to punish non-Hellknights who get their hands on Hellknight plate, and the reward is not usually worth the risk, since for non-Hellknights, the armor is functionally similar to full plate." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Bulwark.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4923a3b1-b93c-4cbb-b4ae-5b420f03c641"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 80
            };
        }
    }
}
