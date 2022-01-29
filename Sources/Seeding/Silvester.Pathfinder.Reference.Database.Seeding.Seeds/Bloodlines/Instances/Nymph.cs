using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Nymph : Template
    {
        public static readonly Guid ID = Guid.Parse("6518234e-d592-4b94-a33e-dd0a4a9c42cd");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Nymph",
                BloodMagic = "Nymph grace accentuates your movements and distracts your foes, either granting you a +1 status bonus to Diplomacy checks for 1 round or imposing a -1 status penalty on one target's Will saves for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.NymphsToken.ID,
                AdvancedBloodlineSpellId = Spells.Instances.BlindingBeauty.ID,
                GreaterBloodlineSpellId = Spells.Instances.EstablishWard.ID,
                SpellListTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e4c086ea-5ebb-460c-94e5-9a91ca0abcc9"), Type = TextBlockType.Text, Text = "One of your ancestors was inspired by a nymph, or perhaps was a nymph themself, and now the beauty of nature lives in you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("12d258ef-d720-4d6f-872c-84ba5762a300"), MagicTraditions.Instances.Primal.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("4ba71532-6d07-46bc-9a1d-8d278907aa8e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("d6951c33-46b8-4884-8df1-c063c42b3e5f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);

            builder.GainSpecificSpell(Guid.Parse("b6ff497f-e596-4c5c-8e8f-0e51bbdbcb9a"), Spells.Instances.NymphsToken.ID);
            builder.GainSpecificSpell(Guid.Parse("974de99f-68fb-4ab0-abe1-fe928e370f45"), Spells.Instances.Tanglefoot.ID);
            builder.GainSpecificSpell(Guid.Parse("2b84930e-4bac-4a8b-9420-4b65a71ff576"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("d2026fd0-5f22-43b8-9bd6-48027d302a18"), Spells.Instances.CalmEmotions.ID);
            builder.GainSpecificSpell(Guid.Parse("3bf08a1a-d1c1-4e67-bf73-11406a25d3bd"), Spells.Instances.AnimalVision.ID);
            builder.GainSpecificSpell(Guid.Parse("092d1a0b-709b-4965-9c98-d3d387acaf55"), Spells.Instances.VitalBeacon.ID);
            builder.GainSpecificSpell(Guid.Parse("8e17dc36-0194-4a83-be1d-6ab6e79a608a"), Spells.Instances.CrushingDespair.ID);
            builder.GainSpecificSpell(Guid.Parse("c203cc3d-5d43-47d8-b12b-c67ffae5eacc"), Spells.Instances.Repulsion.ID);
            builder.GainSpecificSpell(Guid.Parse("f59ca284-ad1d-4a4a-9e4a-04c5f0f243f2"), Spells.Instances.UnfetteredPack.ID);
            builder.GainSpecificSpell(Guid.Parse("a0cacfa3-2f27-4948-856f-91f5111c3b09"), Spells.Instances.MomentOfRenewal.ID);
            builder.GainSpecificSpell(Guid.Parse("5ca5822a-6880-4bd9-ab8c-e05d8401b85d"), Spells.Instances.OverwhelmingPresence.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0179cc8-18d5-4bea-bfad-29fe916accf7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 138
            };
        }
    }
}
