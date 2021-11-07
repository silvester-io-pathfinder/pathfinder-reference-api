using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PilgrimsToken : Template
    {
        public static readonly Guid ID = Guid.Parse("d44868a5-8f96-4f5e-8d57-49e4823242f0");

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
            yield return new TextBlock { Id = Guid.Parse("6e636d79-9afb-4f98-b194-552d0d8841b8"), Type = TextBlockType.Text, Text = "You carry a small token of protection from a site holy to your faith, or you touched your religious symbol to a relic or altar at such a site. So long as this token is in your possession, when you tie an adversary’s initiative roll, you go first." };
            yield return new TextBlock { Id = Guid.Parse("5fd41e33-0cf4-4f41-b636-c4fa6db0b6b5"), Type = TextBlockType.Text, Text = "~ Special: If you select this feat at 1st level, you receive your pilgrim’s token for free. Alternately, if you have a religious symbol, it is already attuned, as described above." };
            yield return new TextBlock { Id = Guid.Parse("76f1ee15-dac3-4d0f-bc9b-5e1c8424b9a2"), Type = TextBlockType.Text, Text = ":&gt; If you select this feat at a later level, or if you lose your pilgrim’s token, you must purchase or (action: Craft) a replacement and attune it at a holy site. Such a token usually costs at least 2 sp, and the attunement takes 10 minutes of prayer and requires a successful DC 20 Religion check. Your GM might adjust the price and DC depending on the token’s material and quality and the religious significance of the site; the more significant the location, the easier the attunement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b86ddad4-e00e-4143-b2fd-64aa85849240"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d46e61f-041c-4738-8106-d385f10f4dec"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
