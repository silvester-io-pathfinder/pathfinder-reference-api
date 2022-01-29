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
    public class InterferingSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("8f8bc5de-d08a-4cd4-983f-0a62269e77df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Interfering Surge",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: primal), or (trait: occult)).",
                Trigger = "A creature you can see Casts a Spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12dbbd96-7c3e-4d24-98d7-5f6ff3efd116"), Type = TextBlockType.Text, Text = $"You overcharge the triggering spell with magic. You expend a spell slot and attempt to counteract the triggering spell using the energy of the expended slot. If the triggering spell is in your repertoire and the spell slot you expended was a high enough level to cast it, you take no penalty. Otherwise, you take a –2 penalty to the counteract check if the triggering spell was cast using the same magical tradition you cast, or a –5 penalty if it was cast using a different tradition." };
            yield return new TextBlock { Id = Guid.Parse("3a79196f-04af-4d6e-a3b8-8d38c9071099"), Type = TextBlockType.Text, Text = $"If the triggering spell is successfully counteracted, it creates a wellspring surge from its caster in addition to the normal effects of being counteracted. If it isn't counteracted, your expended spell slot creates a wellspring surge from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0b4682fe-0303-4878-a9e3-43a74b94f09b"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17d4a5f9-7e12-4c37-be81-f699dd2a8736"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
