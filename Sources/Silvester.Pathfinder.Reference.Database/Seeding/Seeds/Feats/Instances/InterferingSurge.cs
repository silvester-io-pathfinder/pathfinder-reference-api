using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InterferingSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("a83ddb4d-9130-4ea8-9a6d-ec69b1162888");

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
            yield return new TextBlock { Id = Guid.Parse("fe4346ed-1ab9-40f3-9d30-5a924ec81d65"), Type = TextBlockType.Text, Text = "You overcharge the triggering spell with magic. You expend a spell slot and attempt to counteract the triggering spell using the energy of the expended slot. If the triggering spell is in your repertoire and the spell slot you expended was a high enough level to cast it, you take no penalty. Otherwise, you take a –2 penalty to the counteract check if the triggering spell was cast using the same magical tradition you cast, or a –5 penalty if it was cast using a different tradition." };
            yield return new TextBlock { Id = Guid.Parse("55ee11d9-4862-4f0b-bd35-c21dea4bf2e0"), Type = TextBlockType.Text, Text = "If the triggering spell is successfully counteracted, it creates a wellspring surge from its caster in addition to the normal effects of being counteracted. If it isn’t counteracted, your expended spell slot creates a wellspring surge from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0b9fc5b9-5056-4256-aee8-995fc6b62b6f"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("998b5d13-a9b5-4601-bc01-b7d8bb05ec7c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
