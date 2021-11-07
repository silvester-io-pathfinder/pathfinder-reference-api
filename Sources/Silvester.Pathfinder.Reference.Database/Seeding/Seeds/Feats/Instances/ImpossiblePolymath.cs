using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpossiblePolymath : Template
    {
        public static readonly Guid ID = Guid.Parse("a1e6786e-838f-4970-9bc2-47b1947e1e9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Polymath",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c7e90d07-9dd0-4df4-b8b7-9f6ee7e178a0"), Type = TextBlockType.Text, Text = "Your esoteric formulas are so unusual that they allow you to dabble in magic from diverse traditions that other bards don’t understand. As long as you’re trained in Arcana, you can add arcane spells to your book from (feat: Esoteric Polymath); as long as you’re trained in Nature, you can add primal spells to your book; and as long as you are trained in Religion, you can add divine spells to your book." };
            yield return new TextBlock { Id = Guid.Parse("6481643a-47dd-495e-a1cb-2243968fe4c2"), Type = TextBlockType.Text, Text = "Like your other spells in your book, you can add one of these spells from another tradition to your repertoire as an occult spell each day using (feat: Esoteric Polymath), but you can’t retain any spells from another tradition when you prepare again, even if you have (feat: Eclectic Polymath)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("58d42534-a7c5-473d-845e-17377f47552e"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("fde47ee4-6ff4-4eda-b330-c2766f19a510"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("f05f6b96-f99a-4758-bdbf-044cad696148"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("8c505617-b960-444c-a344-85a22ae4437d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("948256d2-abda-4a91-bef5-adee0210bb5e"), Feats.Instances.EsotericPolymath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16b973cf-aff2-4c5a-a376-66791ee2e9ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
