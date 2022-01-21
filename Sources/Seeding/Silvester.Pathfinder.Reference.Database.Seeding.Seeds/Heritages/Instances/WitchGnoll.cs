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
    public class WitchGnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("e355dd89-a128-4d8f-84dc-17e5710e97ff");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Witch Gnoll"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f72e8192-8fa1-45e4-9f4e-41e082267c96"), Type = TextBlockType.Text, Text = "You're a shaggy, dark-furred gnoll capable of making some truly uncanny sounds. You can cast the ghost sound cantrip as an occult innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. In addition, you gain a +1 circumstance bonus to checks to Impersonate and Create a Diversion when using only your voice." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInnateSpell(Guid.Parse("c24d77e5-4071-4484-abb1-854c0582dbfc"), Spells.Instances.GhostSound.ID, MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse("402c02f4-3653-4321-9676-ae40671399b6"), SkillActions.Instances.Impersonate.ID, bonus: 1, addendum: "When only using your voice."); 
            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse("2a1b6d7d-5bbc-4dab-b41b-be99e8aef212"), SkillActions.Instances.CreateADiversion.ID, bonus: 1, addendum: "When only using your voice."); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5a5610a-a937-49f5-9ff7-20ced64b1c84"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 112
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnoll.ID;
        }
    }
}
