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
    public class Ng : Template
    {
        public static readonly Guid ID = Guid.Parse("9e3e7ea7-410e-47a3-8f9d-4fd17337403f");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Ng",
                Edicts = "Travel, hide your identity and your motives.",
                Anathema = "Sleep in the same place twice in a row, wear seasonal decorations out of season.",
                Title = "The Hooded",
                AreasOfConcern = "Changing seasons, secrets, and wanderers.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("678e4aef-2fdb-4cce-9d33-2aee0345ccec"), Type = TextBlockType.Text, Text = "Rumors say that to glance upon the hooded face of Ng is to either see truth or face oblivion itself, but the Eldest of changing seasons, secrets, and wanderers keeps his visage perpetually shrouded. He is a serious and stern figure draped in silvery robes that swish around his legs as he walks lonely and distant paths. No carefree wanderer, Ng is a patron of those who travel long distances with purpose, and he sometimes shields them from banditry, treacherous weather, and getting lost. Ng keeps many secrets, even from his followers, and none know what his evidently aimless travels might portend. Ng rules over the seasons as they turn one into another, but he rules far more numerous seasons than the four familiar to Golarion, such as the Season of Carnivorous Light and the Season of Solemn Deliquescence." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("9f016208-7257-467c-bfa9-2e13e26d466a"), Spells.Instances.PassWithoutTrace.ID);
            builder.GainSpecificSpell(Guid.Parse("d2da76aa-2e7b-4f6a-9a21-12ed56d43061"), Spells.Instances.Invisibility.ID);
            builder.GainSpecificSpell(Guid.Parse("929690e6-da41-400a-829b-e98ac5774ece"), Spells.Instances.Blink.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Gauntlet.ID;
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
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Travel.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("07e745d1-f2b3-486d-97a1-94dc72275f6e"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
