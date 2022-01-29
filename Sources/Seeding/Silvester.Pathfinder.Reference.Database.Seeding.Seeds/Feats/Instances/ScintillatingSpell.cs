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
    public class ScintillatingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("5077d2d0-dff8-4d83-bd8d-9fbf6e610963");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scintillating Spell",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74417252-789c-475a-918c-94f487fe078c"), Type = TextBlockType.Text, Text = $"Your spells become a radiant display of light and color. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that doesn't have the {ToMarkdownLink<Models.Entities.Trait>("darkness", Traits.Instances.Darkness.ID)} trait, has no duration, and requires creatures to attempt a Reflex save, the spell explodes in a spray of scintillating lights, in addition to its other effects. Each creature that failed its Reflex save against the spell is dazzled for 1 round, and those who critically failed are instead blinded for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aca62fa1-60e7-4f7b-9c3c-3b77bbd51da6"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("533a92a9-a0e0-440b-bdb3-aabb522b6d78"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("a6418495-b31a-46ec-a3e6-b8935d94dda1"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("5ce37ea6-1b0d-46a4-aa74-046f128fbf3f"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("081dee89-c06a-43b2-ad77-41edd62c1cea"), Traits.Instances.Sorcerer.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bcdb62a9-ef2d-4d91-a4f7-04bd84f0a4fe"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
