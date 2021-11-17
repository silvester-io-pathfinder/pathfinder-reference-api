using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Kabriri : Template
    {
        public static readonly Guid ID = Guid.Parse("c97fe009-62bb-4444-99b7-6325e7ed28cb");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Kabriri",
                Edicts = "Eat the flesh of your own kind.",
                Anathema = "Reveal secrets of the dead to nonbelievers, despoil grave markers.",
                Title = "Him Who Gnaws",
                AreasOfConcern = "Ghouls, graves, and secrets kept by the dead.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("bf518214-20fb-447b-a70f-d0d898adc2df"), Type = TextBlockType.Text, Text = "Kabriri, Him Who Gnaws, is the demon lord of ghouls, graves, and secrets kept by the dead. According to legend, Kabriri is the reborn form of the first humanoid to devour his kin in life. His realm, Everglut, is connected to graveyards throughout the multiverse by a snarled network of tunnels that bring knowledge and sacrifices to the demon lord. Kabriri appears as a hulking ghoul with elven ears, teeth filed to points, an unnaturally long tongue, ashen skin, and cloven hooves. He is worshipped primarily by ghouls, ghasts, and lacedons." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("9e582ce6-8c99-4875-ad00-808a62916a79"), Spells.Instances.Jump.ID);
            builder.GainSpecificSpell(Guid.Parse("9be2f1b5-3aee-4d26-8711-d4327b625b4d"), Spells.Instances.ExpeditiousExcavation.ID);
            builder.GainSpecificSpell(Guid.Parse("5c4139ce-89b7-47e8-a106-95c7ca30e797"), Spells.Instances.Paralyze.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Flail.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            
            yield return UnarmedWeapons.Instances.Jaws.ID;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Undeath.ID;
            yield return Domains.Instances.Vigil.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("6acd97fc-0a04-44e9-81b3-558141e89b83"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
