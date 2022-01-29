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
    public class ShoulderCatastrophe : Template
    {
        public static readonly Guid ID = Guid.Parse("864081a9-16b3-4742-8672-a7677e7dc04a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shoulder Catastrophe",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy critically succeeds at a Strike against an adjacent ally.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f7330b6-4591-419c-948d-446872d57823"), Type = TextBlockType.Text, Text = $"You've trained to protect your allies by diverting the worst attacks to yourself. The enemy doesn't double the damage from the triggering {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} but instead applies the normal damage to both you and your ally. Both of you take any effects that would happen on a hit that dealt damage, such as poison, but neither of you are subject to any effects that would happen only on a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4b7ec33a-cd7f-4570-b876-c470f3cda6a2"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a4d89e8-74aa-4e51-a928-88e20ac926a3"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
