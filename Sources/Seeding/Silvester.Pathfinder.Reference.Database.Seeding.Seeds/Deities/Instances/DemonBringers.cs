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
    public class DemonBringers : Template
    {
        public static readonly Guid ID = Guid.Parse("7c251772-267e-442f-bd8d-5317b8cc474a");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Demon Bringers",
                Edicts = "Create fortifications and defenses to protect those who can't protect themselves, improve your hunting abilities, seek out evils that threaten others.",
                Anathema = "Exclude innocents from safe havens, intentionally destroy a shelter, allow demon summoners to live on unpunished.",
                
                AreasOfConcern = "Protection, retribution, and keeps.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("a4baaf34-f741-411c-a426-1caa0cbc63d5"), Type = TextBlockType.Text, Text = "The Mwangi Expanse is full of dangers. Of particular note are the variousdemonsand otherAbyssalcreatures that roam the jungles. Many of these creatures are drawn to the Mwangi Expanse by the presence ofAngazhan'sorLamashtu'smight, while others are direct servitors of those faithful to the demonic. While the Mwangi Expanse is home to many demon hunters that keep these evil forces at bay, many of them work in independent groups. It's only with the combined efforts of the demon hunters that the Mwangi Expanse can be rid of this demonic presence and the people of the Mwangi Expanse can be safe." };
            yield return new TextBlock { Id = Guid.Parse("0325d60d-c1d2-4de7-9af9-38ba618918e0"), Type = TextBlockType.Text, Text = "The demon hunters among the Ekujae elves, Matanji orcs, Mwangi catfolk, Mbe'ke dwarves, and others began to join forces in their demon hunts and brought their respective gods with them. This led to the worship of a pantheon of righteous gods that both offered the might to destroy demons and the wisdom to defend others. Through the worship ofAdanye,Chohar,Kazutal(in her form as Majagua), andTorag, these mighty hunters find the strength they need to make the Mwangi Expanse a safer place. While this pantheon didn't originally have a name, the local Mwangi populations eventually dubbed them the Demon Bringers, as their faithful would bring home trophies in the form of demon heads, claws, or tails. Followers of the Demon Bringers use their skills to hunt demons and other evils that lie within the Mwangi Expanse. They also help create homes and fortifications for those that can't fight, as the ultimate goal of the Demon Bringers is a safer Mwangi for all." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("5236d304-084d-48ef-9998-aefa75b04fcf"), Spells.Instances.MageArmor.ID);
            builder.GainSpecificSpell(Guid.Parse("b9b2a308-96a6-4b91-8b57-7070b0321901"), Spells.Instances.Creation.ID);
            builder.GainSpecificSpell(Guid.Parse("73abc3f7-9c94-48e1-9f5c-c1d8cc59f565"), Spells.Instances.TrueTarget.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Khopesh.ID;
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
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("996441d1-8310-4beb-b9b7-73fbe6ff63c1"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 0
            };
        }
    }
}
