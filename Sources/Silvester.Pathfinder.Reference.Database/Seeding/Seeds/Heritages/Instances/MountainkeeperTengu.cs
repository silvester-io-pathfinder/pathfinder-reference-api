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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You come from a line of tengu ascetics, leaving you with a link to the spirits of the world and the Great Beyond. You can cast the disrupt undead cantrip as a primal innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. Each time you cast a spell from a tengu heritage or ancestry feat, you can decide whether it’s a divine or primal spell." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInnateSpell(Guid.Parse(""), Spells.Instances.DisruptUndead.ID, MagicTraditions.Instances.Primal.ID);
            builder.Manual(Guid.Parse(""), "Each time you cast a spell from a tengu heritage or ancestry feat, you can decide whether it’s a divine or primal spell.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
