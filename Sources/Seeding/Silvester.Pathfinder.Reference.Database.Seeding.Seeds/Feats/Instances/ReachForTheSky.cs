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
    public class ReachForTheSky : Template
    {
        public static readonly Guid ID = Guid.Parse("411d058d-e5b0-4e73-a9b8-2ee9e5649c47");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reach for the Sky",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac27dbd3-e2b1-4c2c-abd1-e09797da8597"), Type = TextBlockType.Text, Text = $"You command the room, firing a gun into the air and ordering everyone to surrender and put their hands in the air. You fire your firearm and then attempt a single Intimidation check to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} each enemy within 30 feet. Creatures who become frightened instinctively put their hands in the air. If they had {ToMarkdownLink<Models.Entities.Action>("Raised a Shield", Actions.Instances.RaiseAShield.ID)}, they lose the benefits, as they raise the shield above their head where it's of little use to block attacks. With their hands in the air, each of these frightened creatures can't use reactions or free actions that require their hands, or items held in their hands, until the beginning of their next turn. Regardless of the result, each creature is then temporarily immune to Reach for the Sky for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a614119c-c700-4e39-81bd-249e9e91b37a"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e0db226d-ae38-4437-9533-37c1b59656d6"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("d5d2fb9a-8777-45a7-a951-6d084fb11092"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("bef51384-41db-4608-99a0-d977959b768c"), Traits.Instances.Visual.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c5551ce-f41b-4616-a0ef-77b92d0a51c9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
