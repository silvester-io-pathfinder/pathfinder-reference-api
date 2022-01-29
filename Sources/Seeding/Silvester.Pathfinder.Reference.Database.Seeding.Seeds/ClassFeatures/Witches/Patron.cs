using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class Patron : Template
    {
        public static readonly Guid ID = Guid.Parse("c494e0c9-135d-4093-9423-8b6b8456f73b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Patron", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9bacbbda-2595-47ef-a127-9e17a6bf09cb"), Type = TextBlockType.Text, Text = "You weren't born with the power to cast spells, nor have you spent years in devotion to tomes, deities, or mystical secrets. Your power comes through a potent being that has chosen you as their vessel to carry forth some agenda in the world. This entity is typically mysterious and distant, revealing little of their identity and motivations, and they grant you spells and other magical powers through a familiar, which serves as a conduit for their power." };
            yield return new TextBlock { Id = Guid.Parse("512baafb-17cb-4aac-b7aa-f61d23f0ecdb"), Type = TextBlockType.Text, Text = "A patron might be a deity or demigod, a coven of powerful hags, a fey lord, an archdevil, or a similarly powerful entity, or perhaps multiple such figures working in tandem. As you gain more of your patron's power, you might learn more about who or what they are - certain combinations of themes and lessons suggest particular patrons or agendas - but patrons empower witches for their own secretive reasons, which they rarely reveal in full." };
            yield return new TextBlock { Id = Guid.Parse("17683e4a-5373-4039-a8d7-3c56437eefc4"), Type = TextBlockType.Text, Text = "At 1st level, choose your patron's theme, which determines your spellcasting tradition, a skill, a special cantrip you gain, and a spell added to your familiar. The patron themes can be found here." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyPatronTheme(Guid.Parse("9aecb47e-fd79-437f-af6e-497aa80f1371"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e5ae8f1-92fc-4c65-aff7-0e535067f1b0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 96
            };
        }
    }
}
