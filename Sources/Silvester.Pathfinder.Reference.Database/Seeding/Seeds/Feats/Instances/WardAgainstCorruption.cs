using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardAgainstCorruption : Template
    {
        public static readonly Guid ID = Guid.Parse("6e62b85c-1fb3-4596-8f9d-e39c72ccd0ba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ward Against Corruption",
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
            yield return new TextBlock { Id = Guid.Parse("2670991e-43f9-4946-ba50-fade49971094"), Type = TextBlockType.Text, Text = "Your soul is warded against the power of undeath and plague, as well as that of the evil former psychopomps known as sahkils. You gain a +1 circumstance bonus to saving throws against (trait: death) effects, disease, and all effects from undead or sahkils. This bonus increases to +2 against an undead or sahkil&#39;s (trait: death) effect or disease." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9475250f-151c-46b6-9a24-63227bfc1550"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
