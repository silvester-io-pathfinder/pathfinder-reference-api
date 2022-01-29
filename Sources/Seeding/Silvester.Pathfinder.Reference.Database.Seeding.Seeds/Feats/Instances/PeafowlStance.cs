using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeafowlStance : Template
    {
        public static readonly Guid ID = Guid.Parse("9e131478-f0b9-4809-94f2-6938ad89117c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peafowl Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a795837c-a586-414e-9596-4d9e25f3c8e5"), Type = TextBlockType.Text, Text = $"You enter a tall and proud stance while remaining mobile, with all the grace and composure of a peafowl. While in this stance, the only {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you can make are melee {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} with the required sword. Once per round, after you hit with a monk sword {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, you can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} as a free action as your next action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("99a46a03-b852-486e-b81b-2713c2776529"), Feats.Instances.MonasticWeaponry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e2c8ac3-e9d1-4a85-8e20-5a27473d84cb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
