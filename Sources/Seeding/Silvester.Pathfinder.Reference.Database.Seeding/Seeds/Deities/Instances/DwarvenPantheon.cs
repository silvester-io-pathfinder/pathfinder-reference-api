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
    public class DwarvenPantheon : Template
    {
        public static readonly Guid ID = Guid.Parse("d57f4ef3-02d3-4668-8745-b7d4de16c7ef");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Dwarven Pantheon",
                Edicts = "Develop skills useful to your community (especially crafting, mining, and trading), honor your ancestors through traditions and rituals.",
                Anathema = "Dishonor your family, willingly break a contract or oath, irreparably damage an ancestral relic.",
                
                AreasOfConcern = "Ancestry, crafting, dwarves, relationships.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("0dc4fc9d-945e-4790-a849-baf658ffb7e2"), Type = TextBlockType.Text, Text = "The dwarven gods are one large family, withToragas its patriarch. He is joined by his brothersMagrim(the Taskmaster) andAngradd(the Forge Fire), his half-sisterDranngvit(the Debt Minder), and his wifeFolgrit(the Watchful Mother). His children areBolka(the Golden Gift),Grundinnar(the Peacemaker),Kols(the Oath-Keeper), andTrudd(the Mighty). Torag's evil former studentDroskar(the Dark Smith), though technically part of the dwarven pantheon, is rarely invoked by any save duergars." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("5978e107-2ab6-4ab3-8d79-e94db646c83f"), Spells.Instances.AntHaul.ID);
            builder.GainSpecificSpell(Guid.Parse("361ac9d1-44b7-4419-9721-316f627f6939"), Spells.Instances.Creation.ID);
            builder.GainSpecificSpell(Guid.Parse("918b8565-997b-4125-ac16-5876a6dfc22d"), Spells.Instances.Retrocognition.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Warhammer.ID;
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
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Protection.ID;
            yield return Domains.Instances.Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("c61b2291-44ad-46d8-a386-00ecb7625a4c"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 92
            };
        }
    }
}
