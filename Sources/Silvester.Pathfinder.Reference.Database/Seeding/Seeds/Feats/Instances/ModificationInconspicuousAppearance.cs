using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationInconspicuousAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("d89f42f2-7ace-41f4-b86b-dae102f1e4b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Inconspicuous Appearance",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80b8f391-176d-44a6-8f2a-c2a608cae9cd"), Type = TextBlockType.Enumeration, Text = "*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("a771c5f3-1fb4-4457-85f8-bd84ae341acc"), Type = TextBlockType.Text, Text = "Your innovation is built for easy concealment and surprise attacks. It gains the (trait: backstabber) and (trait: versatile P) traits. If the weapon has light Bulk, it also gains the (trait: concealable) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8f50376-c5fe-4bc0-9b75-738e2a4a59c5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
