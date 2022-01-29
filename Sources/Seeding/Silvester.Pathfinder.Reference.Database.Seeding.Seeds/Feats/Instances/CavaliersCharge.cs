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
    public class CavaliersCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("05ac1b8f-875d-46c4-840c-c3c762145067");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cavalier's Charge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71ed6226-320d-4363-9b24-aafa1908444f"), Type = TextBlockType.Text, Text = $"You {ToMarkdownLink<Models.Entities.SkillAction>("Command an Animal", SkillActions.Instances.CommandAnAnimal.ID)} to order your mount to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} twice. At any point during this movement, you can {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} one enemy within reach or within the first range increment of a ranged weapon. You gain a +1 circumstance bonus to your attack roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("44daecd2-2002-44f3-b3c2-b500d6f9110f"), Feats.Instances.CavalierDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3de7c0f0-4b90-4468-98d3-aab42d96e3b0"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("eae6bf24-992c-4cf9-8a93-7d54e3a46c56"), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58901dca-b174-473a-89bc-129f7b3817c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
