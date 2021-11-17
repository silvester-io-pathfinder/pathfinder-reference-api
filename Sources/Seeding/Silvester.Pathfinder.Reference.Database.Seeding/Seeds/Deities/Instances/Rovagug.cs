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
    public class Rovagug : Template
    {
        public static readonly Guid ID = Guid.Parse("7ab4653d-508d-413b-83b7-547d4c0325c0");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Rovagug",
                Edicts = "Destroy all things, free Rovagug from his prison.",
                Anathema = "Create something new, let material ties restrain you, torture a victim or otherwise delay its destruction.",
                Title = "The Rough Beast",
                AreasOfConcern = "Destruction, disaster, and wrath.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("9957b892-b1c8-42a6-ba89-4e45a5bf9648"), Type = TextBlockType.Text, Text = "Rovagug has no single holy scripture. He has little use for one, for his sole commandment is to destroy, and his followers need no instruction in how to accomplish that. The figurative and literal monsters who worship Rovagug share their myths and legends in secret shrines and hidden caves, calling him the Rough Beast, the Imprisoned King, the Tide of Fangs, the Unmaker, and the Worldbreaker. They tell each other that each life they snuff out, each piece of art they destroy, each work of labor they bring tumbling down puts a crack in the prison that holds their god. Each of their little efforts of destruction adds up and will one day free him, setting him loose to bring about the end of all things." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("28cf7255-d823-4c73-83c4-6e1a70998b13"), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse("f7a03cb4-9113-458d-9f1c-ce19426f511b"), Spells.Instances.Enlarge.ID);
            builder.GainSpecificSpell(Guid.Parse("4187c949-ade4-4d25-87f6-c99311609c3c"), Spells.Instances.Disintegrate.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Greataxe.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse("762622db-c5da-472f-ac75-69baf347010c"),
                Description = "Rovagug’s imprisonment means he can almost never intercede on Golarion, but some places lead far enough into the earth that the god’s profane influence can leak through. He is as likely to curse those who draw his attention as he is to reward them, though great enough acts of violence and destruction may earn his favor.",
                MinorBoon = "Your attack becomes more destructive. Once, one of your failed or successful attacks becomes a critical hit, and your weapon or unarmed attack gains the deadly d12 trait for this attack, replacing any deadly trait it already had. Rovagug typically grants this boon when the critical hit could destroy something precious or significant.",
                ModerateBoon = "You can devour all. You mouth grows into a horrible circular, insectile maw of needle-like teeth. You gain a bite unarmed attack that deals 1d8 piercing damage. Additionally, you can stomach eating anything you can fit down your throat—even rocks or small objects. You gain a +4 status bonus to saves resulting from eating something, such as diseases, poisons, or other effects of the ingested object. This doesn't allow you to digest magic items that would otherwise be difficult or impossible to destroy, such as cursed items or artifacts.",
                MajorBoon = "You can crack the surface of Golarion, accelerating the release of the Rough Beast. You gain the Quaking Stomp barbarian feat.",
                MinorCurse = "Whenever you are imprisoned, you thrash and shake as your mind fills with desperation. Any time you are restrained or otherwise imprisoned (such as being sent to jail), you are also clumsy 2 and stupefied 2.",
                ModerateCurse = "Your destructive rage seeks to remain unbound. Any armor you wear automatically becomes broken. Other items in your possession occasionally become broken over time.",
                MajorCurse = "You are useful only as a beacon of destruction. You are permanently confused, rampaging against anything and everything in your sight, and you deal an additional 18 damage with your unarmed and weapon Strikes.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("d276fb50-666d-48e7-9bf8-2df203b50fec"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 41
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Zeal.ID;
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
                Id = Guid.Parse("01cf6283-0a50-4518-b23e-661b42c6f5e1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
