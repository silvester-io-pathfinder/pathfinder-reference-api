using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MobileShotStance : Template
    {
        public static readonly Guid ID = Guid.Parse("8462ab1c-49d5-4a81-9d96-f36160eb9092");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mobile Shot Stance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a654703e-ebca-4ac0-95fe-c2a1bf8a8eae"), Type = TextBlockType.Text, Text = $"Your shots become nimble and deadly. While you're in this stance, your ranged {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} don't trigger {ToMarkdownLink<Models.Entities.Feat>("Attacks of Opportunity", Feats.Instances.AttackOfOpportunity.ID)} or other reactions that are triggered by a ranged attack." };
            yield return new TextBlock { Id = Guid.Parse("1654811d-b3bd-4728-b57b-0c0028196b23"), Type = TextBlockType.Text, Text = $"If you have {ToMarkdownLink<Models.Entities.Feat>("Attack of Opportunity", Feats.Instances.AttackOfOpportunity.ID)}, you can use it with a loaded ranged weapon you're wielding. The triggering creature must be within 5 feet of you for you to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6e8c70ba-554c-4d2a-96af-1c302bda1482"), Feats.Instances.ArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0a80975-c6a5-415c-bbbe-06e9f0b2d6ee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
