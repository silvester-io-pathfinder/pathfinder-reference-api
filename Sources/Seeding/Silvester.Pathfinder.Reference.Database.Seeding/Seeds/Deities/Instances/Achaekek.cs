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
    public class Achaekek : Template
    {
        public static readonly Guid ID = Guid.Parse("ff2c8e0f-a3bb-4b15-9cbb-4bbc2f6dbf09");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Achaekek",
                Edicts = "Conduct assassinations, spread the Red Mantis's infamy, wield sawtooth sabers in combat.",
                Anathema = "Kill a rightful ruler, become fixated on petty matters such as others' gender or ancestry, abandon an assassination contract you agreed to pursue.",
                Title = "He Who Walks In Blood",
                AreasOfConcern = "Assassins, divine punishments, and the Red Mantis.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("5868adcd-d72b-478f-b080-2195fa183baf"), Type = TextBlockType.Text, Text = "While Achaekek's divine genesis is heavily debated among scholars, it is believed that he was created—either by the power of a singular deity or a group of them—to eradicate those who would steal a god's divinity, and he has since become the enforcer of divine punishment. Known as He Who Walks in Blood, he slumbers in the blood of heretics and worshippers alike in an immense cleft carved into the base of the Boneyard's spire, a realm known as the Blood Vale. He keeps no formal relationships with any other deities, even his sister,Grandmother Spider, who repeatedly coaxes Achaekek to rebel against the gods and abandon his duties. In response, even though some gods disapprove of Achaekek's methods, few openly defy him." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("06cd0ab0-a094-410a-b0c6-66618adcd87b"), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("38889ab2-9f66-4fc1-8638-a49144d2748e"), Spells.Instances.Invisibility.ID);
            builder.GainSpecificSpell(Guid.Parse("335a748e-f5e7-4510-abd1-79e00fcd8ac5"), Spells.Instances.PhantasmalKiller.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.SawtoothSaber.ID;
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
                Id = Guid.Parse("4ef7ffbd-6c85-49ad-a050-153fada5875e"),
                Description = "He Who Walks in Blood detests oathbreakers and bears a particular prejudice against mortals seeking to ascend into divinity, but the Mantis God believes in compensation for selfless duties and rewards the rare individual for their murderous deeds. Violation of his tenets and, occasionally, slights against Grandmother Spider may provoke Achaekek's wrath. ",
                MinorBoon = "You hide among the shadows of death. Once, when you would fail a Stealth check, you critically succeed instead. Achaekek typically grants this boon for an extremely consequential Stealth check that could lead to an assassination, such as one that could get you into position to kill an important target, but rarely on a Stealth check to help you escape.",
                ModerateBoon = "You gain the god's approval to take a life. You can cast death knell once per day as an innate divine spell.",
                MajorBoon = "Death lives in your very blade. You gain the sneak attack rogue class feature, dealing 3d6 precision damage. if you already have that class feature, you increase your sneak attack damage by 3d6.",
                MinorCurse = "Achaekek's minions seek vengeance. Nonsapient insects (especially mantises) become hostile against you.",
                ModerateCurse = "Hubris brings death. Your name and location are mentally projected into the mind of a Red Mantis assassin, who is tasked with eliminating you.",
                MajorCurse = "The Mantis God doesn't waste his time toying with or tormenting those who truly anger him, or those who dare to consider themselves divine. He rips open a portal to your location, kills you, drags your soul to judgment in a way that prevents resurrection magic, and then leaves.Feats Requiring Worship of Achaekek...Red Mantis Assassin Dedication",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("bea881b2-adf9-4db7-b4ad-fa1b000517ac"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 3
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5b1ed6b-446a-432c-8e06-2da811277927"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 52
            };
        }
    }
}
