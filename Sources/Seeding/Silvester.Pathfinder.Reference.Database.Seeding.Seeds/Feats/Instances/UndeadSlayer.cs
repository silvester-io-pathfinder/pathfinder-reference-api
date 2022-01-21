using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UndeadSlayer : Template
    {
        public static readonly Guid ID = Guid.Parse("66d720ea-ee89-4352-a8ce-024578b7519d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Undead Slayer",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aac20fac-fa32-48d8-8b86-e816e3cb3d93"), Type = TextBlockType.Text, Text = "Your knowledge of your own not-quite-living anatomy, combined with your experience in combat, helps you take down undead foes with ease. Against undead creatures, you gain a circumstance bonus to damage with weapons and unarmed attacks equal to the number of weapon damage dice for the (action: Strike). This bonus increases to double the number of weapon damage dice if your target has the (trait: vampire) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb63ea8c-f93f-4a6a-bd48-12bbd5750b9d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
