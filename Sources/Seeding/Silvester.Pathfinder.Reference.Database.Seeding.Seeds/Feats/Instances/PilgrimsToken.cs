using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PilgrimsToken : Template
    {
        public static readonly Guid ID = Guid.Parse("660461fe-52b4-4763-8ed4-ecfe7aefca61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pilgrim's Token",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a5d920a-213f-4e7f-a775-bb56fcea8a36"), Type = TextBlockType.Text, Text = $"You carry a small token of protection from a site holy to your faith, or you touched your religious symbol to a relic or altar at such a site. So long as this token is in your possession, when you tie an adversary's initiative roll, you go first." };
            yield return new TextBlock { Id = Guid.Parse("38cfa375-c376-4a0f-9554-14595043a4d8"), Type = TextBlockType.Text, Text = $"~ Special: If you select this feat at 1st level, you receive your pilgrim's token for free. Alternately, if you have a religious symbol, it is already attuned, as described above." };
            yield return new TextBlock { Id = Guid.Parse("b7b6eccc-a6b7-47e5-9a95-772f0bddc640"), Type = TextBlockType.Text, Text = $":&gt; If you select this feat at a later level, or if you lose your pilgrim's token, you must purchase or {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} a replacement and attune it at a holy site. Such a token usually costs at least 2 sp, and the attunement takes 10 minutes of prayer and requires a successful DC 20 Religion check. Your GM might adjust the price and DC depending on the token's material and quality and the religious significance of the site; the more significant the location, the easier the attunement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c8fdeaf3-f22c-4c7f-ae19-d3da37f482d7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26894672-3432-4f4c-aea6-0beebba1df54"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
