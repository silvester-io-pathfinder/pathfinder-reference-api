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
    public class Zohls : Template
    {
        public static readonly Guid ID = Guid.Parse("3fb7b19a-dd2e-4eee-9a00-59e95325afa2");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Zohls",
                Edicts = "Solve logic puzzles, investigate crimes, devise new solutions from research.",
                Anathema = "Make judgments without evidence, contaminate evidence, obstruct truths.",
                Title = "Verity",
                AreasOfConcern = "Determination, investigation, and truth.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("090b3830-524b-41f8-9c52-f7b7aee75ba0"), Type = TextBlockType.Text, Text = "Zohls, also known as Verity, advocates for determination, investigation, and truth. She believes that mysteries lead to truth, but how one arrives at that truth is as important as the answer itself. All questions are puzzles, and all puzzles are worth solving. The more intricate the problem, the more rewarding the investigation, and through determination and ethical investigation, even the deepest of enigmas can be solved. Calculated, logical thinking is more important to Zohls than gut instinct. She sees patterns everywhere, and she teaches that detecting these patterns brings the truth to light. While all investigations are worth pursuing so long as they don't hurt innocents, investigations that reveal the truth of crimes or other horrors, and that lead to justice being served and victims finding peace, are the most important of all to Verity." };
            yield return new TextBlock { Id = Guid.Parse("5158558a-6403-4e97-8659-966674caa3b0"), Type = TextBlockType.Text, Text = "When appearing to her followers, Verity is always practically dressed, usually wearing a tunic and breeches. She wears black and white clothing, as these colors represent the light of truth and the darkness of obscurity and the unknown. She keeps her light-brown hair pulled back in braids. On her back she has large wings made of parchment that never wrinkle, whether furled or unfurled. Followers of Zohls include detectives, scientists, researchers, historians, archivists, librarians, and even conspiracy theorists." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("98ac9b2e-192f-400b-a2ae-4ee8560e048f"), Spells.Instances.ShareLore.ID);
            builder.GainSpecificSpell(Guid.Parse("0bf7e51f-49af-4a47-b5a4-bbe5bfba83d4"), Spells.Instances.Hypercognition.ID);
            builder.GainSpecificSpell(Guid.Parse("ec46f337-423f-41af-90e7-fe370a209d23"), Spells.Instances.Retrocognition.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return Items.RangedWeapons.Instances.HeavyCrossbow.ID;
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
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Cities.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Truth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("479c668e-1291-458f-a871-f62c23c2f49e"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
