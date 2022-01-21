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
    public class TheFreeingFlame : Template
    {
        public static readonly Guid ID = Guid.Parse("84dab2e3-cec2-448b-bfb1-de3f79e0f568");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "The Freeing Flame",
                Edicts = "Free others from oppression, release harmful tethers be they physical or spiritual, work toward your best self and inspire others to follow.",
                Anathema = "Allow tyrants to escape punishment after their reign ends, enslave or oppress others, prevent others from honestly expressing themselves.",
                
                AreasOfConcern = "Liberation, toppling tyranny, and self-realization.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("927547ca-ad7f-408d-a243-9101119c8b8f"), Type = TextBlockType.Text, Text = "Local stories say that the people of Vidrian had the support of the gods when the time came for revolution.Lubaikoprovided the first flames of rebellion, literally igniting the first cart that led to the initial confrontation at a plantation on the outskirts of Eleder. The tales then note that the casks on the cart erupted as the first blow was struck, creating a massive explosion that woke everyone on the plantation. Many say this wasCayden Cailean'sway of showing his support. As everyone stirred about and watched those first servants and slaves fight, others were fearful of the consequences. It was the touch of hope thatMilanigranted them that finally gave them the strength to rise up and fight for freedom." };
            yield return new TextBlock { Id = Guid.Parse("0f9f99af-32e2-47fc-8d3b-e4fc4ecf2d4a"), Type = TextBlockType.Text, Text = "Whether or not the stories hold truth, the Freeing Flame remains a notable pantheon among the people of Vidrian today. The young nation broke free from the shackles of oppression and now looks toward bettering itself in the future, a mantra that many Vidrics and followers of the Freeing Flame follow for themselves. With the guidance of Milani, the courage of Cayden, and the inspiration of Lubaiko, a faithful can burn away maladies of the heart to become a person that is free to do as they wish, but also do so without infringing on others. Some follow these ideals to stop tyrants and liberate those that can't live freely, while others take these teachings to become independent figures with little concern of others' expectations." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("32868c2c-0f28-4f10-8d8c-9909180ac187"), Spells.Instances.AnticipatePeril.ID);
            builder.GainSpecificSpell(Guid.Parse("b7b66c91-7d42-4760-b568-6de57c2a8d69"), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse("92662842-d66d-4d23-a06d-69af028d549a"), Spells.Instances.Mislead.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.SwordCane.ID;
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
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e308050-5645-4503-b40b-249a45f4f053"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 0
            };
        }
    }
}
