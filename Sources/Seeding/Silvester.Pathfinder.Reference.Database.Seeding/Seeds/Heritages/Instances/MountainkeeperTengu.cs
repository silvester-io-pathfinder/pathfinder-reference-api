using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class MountainkeeperTengu : Template
    {
        public static readonly Guid ID = Guid.Parse("ad92131b-3931-44f0-a517-f477b241e40f");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Mountainkeeper Tengu"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7c220c7a-bb74-4671-8c70-a036477cb4f5"), Type = TextBlockType.Text, Text = "You come from a line of tengu ascetics, leaving you with a link to the spirits of the world and the Great Beyond. You can cast the disrupt undead cantrip as a primal innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. Each time you cast a spell from a tengu heritage or ancestry feat, you can decide whether it�s a divine or primal spell." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInnateSpell(Guid.Parse("88329060-cae1-4d34-973f-6c23524064aa"), Spells.Instances.DisruptUndead.ID, MagicTraditions.Instances.Primal.ID);
            builder.Manual(Guid.Parse("f8f749e2-a385-48f0-9aca-48d35a37636f"), "Each time you cast a spell from a tengu heritage or ancestry feat, you can decide whether it�s a divine or primal spell.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75baa5e8-e7c9-407f-ae4d-f453a5fd9f66"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 25
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Tengu.ID;
        }
    }
}
