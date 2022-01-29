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
    public class ExplosiveLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("84b63c0f-12f7-4cc2-883e-5e21cefdb5b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explosive Leap",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this action rather than you.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89dd8471-5b53-4d82-8517-c236195e69c8"), Type = TextBlockType.Text, Text = $"You aim an explosion from your innovation downward to launch yourself into the air. You jump up to 30 feet in any direction without touching the ground. You must land on a space of solid ground, or else you fall after using your next action. As normal for effects where you fall after using your next action, you still fall at the end of your turn, even if you don't use any further actions that turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bbb471fc-0a16-48bb-9d1d-484c220e1c93"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("b7e6518c-e1e6-4e80-bf8c-9f1e4b5d63d8"), Traits.Instances.Inventor.ID);
            builder.Add(Guid.Parse("c6e126d9-1aa5-42ea-b9a5-7ffa629bfe66"), Traits.Instances.Move.ID);
            builder.Add(Guid.Parse("8dc3e001-56a6-4b79-ba53-37a284898567"), Traits.Instances.Unstable.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c65ab8e1-2cb6-46ad-944d-5be1402ffa02"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
