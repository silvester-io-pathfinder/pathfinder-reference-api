using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UbiquitousAntithesis : Template
    {
        public static readonly Guid ID = Guid.Parse("dae2f67f-0aed-4b8b-979e-7d9e5e164c27");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ubiquitous Antithesis",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f0a2b71-fd14-4426-81e2-36ad2d54c4a2"), Type = TextBlockType.Text, Text = "You’ve channeled your power into the connections you’ve formed with your comrades, allowing you to share the benefits of your esoterica with all of them. Whenever you use (feat: Esoteric Antithesis), all your allies within 30 feet gain the benefits as well. Since this effect depends on magically strengthening your connection to your allies, only allies with whom you’ve developed a connection over the course of one or more days gain the benefit, rather than new allies you just met." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b491364a-d02c-467e-adfd-b1b200378f00"), Feats.Instances.ShareAntithesis.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3346b6d-e60b-4274-bd49-4d3882897684"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
