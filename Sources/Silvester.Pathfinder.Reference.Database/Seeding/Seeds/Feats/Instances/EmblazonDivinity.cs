using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmblazonDivinity : Template
    {
        public static readonly Guid ID = Guid.Parse("94860e02-7dc2-48ce-bd06-fa772e53c75d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emblazon Divinity",
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
            yield return new TextBlock { Id = Guid.Parse("f0d77e99-a014-4beb-9368-d8d45c9cdac4"), Type = TextBlockType.Text, Text = "Your sacred etchings imbue objects with power. It takes you only 1 minute to emblazon a symbol using (action: Emblazon Armament), and you can have up to four symbols emblazoned at a time. Each item can still have only one symbol emblazoned upon it, and if you exceed the limit of four, the oldest symbol disappears. These symbols can benefit even those who don’t follow the deity, provided they aren’t directly opposed (as determined by the GM)." };
            yield return new TextBlock { Id = Guid.Parse("a0755635-41d3-4e76-b446-42905a6986a1"), Type = TextBlockType.Text, Text = "You can select a different benefit for each emblazoned symbol, chosen from any you have from (feat: Emblazon Armament) or other feats such as (feat: Emblazon Energy) or (feat: Emblazon Antimagic)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("039af8fd-1be1-4736-87bf-2af86d64180a"), Feats.Instances.EmblazonArmament.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f383e28-7c17-46db-8c67-c6e183afb222"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
