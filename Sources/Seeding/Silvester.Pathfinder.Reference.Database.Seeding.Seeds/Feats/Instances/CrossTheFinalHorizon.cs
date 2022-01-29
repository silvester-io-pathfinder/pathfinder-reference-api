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
    public class CrossTheFinalHorizon : Template
    {
        public static readonly Guid ID = Guid.Parse("18a752ae-764b-44cc-b566-2008477189d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cross the Final Horizon",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e8b8003-b374-4278-9e73-4d641e10d5ed"), Type = TextBlockType.Text, Text = $"You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to your Speed and your ki enshrouds your limbs in a terrifying stormy energy, increasing the reach of your {ToMarkdownLink<Models.Entities.Feat>("Sky and Heaven Stance", Feats.Instances.SkyAndHeavenStance.ID)} unarmed attacks by 5 feet." };
            yield return new TextBlock { Id = Guid.Parse("ecca5411-4cce-4818-9045-52a9ed821b5a"), Type = TextBlockType.Text, Text = $"At the end of your movement, make up to three {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against a target you can reach, each at a -2 penalty. Each attack counts toward your multiple attack penalty, but the multiple attack penalty doesn't increase until after you have made all your attacks. Instead of the usual slashing or piercing damage, the damage for these {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} is either electricity or sonic, as you choose with each {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If you successfully hit with all three {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, the target is drained 3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2f4ac502-8de0-4c20-987a-33e1e4b25192"), Feats.Instances.SkyAndHeavenStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("05df9d2c-a2a0-4fac-899f-5de7273728ae"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("a8e6d2a8-e397-42e1-a763-7164e8edf544"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("c855fdd9-eb4a-4c78-a12f-7ed683db88b6"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("b6e4b5d7-9476-4593-8e86-874699e3445b"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("ffbb2ff8-d1bf-47a8-9c32-d42adc594335"), Traits.Instances.Sonic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f19cee9b-73e5-4a04-86b6-cd6b4ab50c5a"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
