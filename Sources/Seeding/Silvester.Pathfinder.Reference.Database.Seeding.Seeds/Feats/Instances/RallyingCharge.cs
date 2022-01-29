using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RallyingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("c559d2bd-1782-4d66-b0a6-91500a57a8ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rallying Charge",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ee719f0-2bcd-41e7-9697-cb499c7a473a"), Type = TextBlockType.Text, Text = $"Your fearless charge into battle reinvigorates your allies to carry on the fight. You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to your Speed and make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits and damages an enemy, each ally within 60 feet who saw you hit gains temporary Hit Points equal to your Charisma modifier. These temporary Hit Points last until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6c466502-0f44-4c7e-bae0-4191521f84fc"), Feats.Instances.MarshalDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b2a1a724-42da-4b75-b969-22b21fb48f47"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("e2f3cf7b-bca7-402e-af1c-e398697aa598"), Traits.Instances.Open.ID);
            builder.Add(Guid.Parse("cb6e18ac-4803-48ab-bc2e-8edff2420c10"), Traits.Instances.Visual.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca50eb17-4145-4bd7-8eaf-855b83850fa3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
