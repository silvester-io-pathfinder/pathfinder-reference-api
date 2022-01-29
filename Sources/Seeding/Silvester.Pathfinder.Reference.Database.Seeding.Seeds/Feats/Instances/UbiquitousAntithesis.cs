using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UbiquitousAntithesis : Template
    {
        public static readonly Guid ID = Guid.Parse("69af2fb1-503d-45f9-b58a-84a9c1a5b3c9");

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
            yield return new TextBlock { Id = Guid.Parse("ab710374-f130-47b6-b73a-e3ee733b58d0"), Type = TextBlockType.Text, Text = $"You've channeled your power into the connections you've formed with your comrades, allowing you to share the benefits of your esoterica with all of them. Whenever you use {ToMarkdownLink<Models.Entities.Feat>("Esoteric Antithesis", Feats.Instances.EsotericAntithesis.ID)}, all your allies within 30 feet gain the benefits as well. Since this effect depends on magically strengthening your connection to your allies, only allies with whom you've developed a connection over the course of one or more days gain the benefit, rather than new allies you just met." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1406de6d-4f3f-49b8-83df-88f36837eee2"), Feats.Instances.ShareAntithesis.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb38d4a4-19d0-435f-9d23-f91538871956"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
