using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KoboldWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("a7f90826-fa24-48c8-88cf-effc23f981c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kobold Weapon Familiarity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37028e59-3b28-4e57-9fc2-adb9ed0382d5"), Type = TextBlockType.Text, Text = "You’ve trained with weapons ideal for subterranean efficiency. You are trained with the (item: crossbow), (item: greatpick), (item: light pick), (item: pick), and (item: spear). You also gain access to all uncommon kobold weapons. For the purpose of determining your proficiency, martial kobold weapons are simple weapons, and advanced kobold weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81986dd1-2082-4d2f-aafa-f2961576a8e0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
