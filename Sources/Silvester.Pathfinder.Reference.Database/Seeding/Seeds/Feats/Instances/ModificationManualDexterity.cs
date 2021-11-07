using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationManualDexterity : Template
    {
        public static readonly Guid ID = Guid.Parse("00fc3fae-8eb0-4892-9122-9f3baf381363");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Manual Dexterity",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23a9c063-9473-4235-8179-548dc344997e"), Type = TextBlockType.Text, Text = "Your construct innovation has articulated hands or similar appendages with significant manual dexterity. It can perform (trait: manipulate) actions with up to two of its limbs. As normal for a companion, it still can’t wield weapons or held items that don’t have the (trait: companion) trait, and it can’t activate items." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("058f5818-4115-4e09-8fdf-e5534f13aecf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
