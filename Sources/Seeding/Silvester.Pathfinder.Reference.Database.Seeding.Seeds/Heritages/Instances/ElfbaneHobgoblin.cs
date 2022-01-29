using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ElfbaneHobgoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("72314e7e-142a-4fe5-bc9a-bf17cf477dfa");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Elfbane Hobgoblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("94014eaa-5bf6-49ec-9f66-be9ea13bfafd"), Type = TextBlockType.Text, Text = "Hobgoblins were engineered long ago from the unreliable and fecund goblins, to be used as an army against the elves. Although the elves ultimately freed the hobgoblins from their bondage, some hobgoblins retain ancestral resistance to magic, which they refer to as 'elf magic'. You gain the Resist Elf Magic reaction." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("b83936ae-ffc0-46c9-a983-38880093083c"), Feats.Instances.ResistElfMagic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2961ac72-1408-4f73-99b0-87993e360c2a"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 49
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Hobgoblin.ID;
        }
    }
}
