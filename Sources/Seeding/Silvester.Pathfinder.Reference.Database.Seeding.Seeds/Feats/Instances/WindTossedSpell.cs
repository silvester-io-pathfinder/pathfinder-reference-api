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
    public class WindTossedSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("3d73d54a-95c8-48d9-81d0-bb30f436d271");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wind-Tossed Spell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae6f3553-4cf6-4d86-92a7-4edef2ec2727"), Type = TextBlockType.Text, Text = $"You enhance your spell with elemental air, using the wind to find your target and carry your magic around cover. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that requires a spell attack roll, you ignore the target's concealed condition and any cover they have from you. The spell gains the {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("800f5b67-1e2b-4696-a2cc-f2a2c57392cc"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7a24062e-2af8-449f-9e0b-80142922c69b"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("fa52db7e-ab09-445e-86ca-8a8d9711321d"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("a5b31e2a-cd58-4a4d-b1fe-83611f20aca8"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("c5f863fb-908b-4158-82dc-4fc04d390ac7"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d5197a6-62ab-4e01-b435-538806e76529"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
