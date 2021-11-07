using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationBluntShot : Template
    {
        public static readonly Guid ID = Guid.Parse("c1951882-1967-4d7f-8cbd-7d3c0758506c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Blunt Shot",
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
            yield return new TextBlock { Id = Guid.Parse("621c11bf-af53-4efc-90fa-0ad2b54c4058"), Type = TextBlockType.Enumeration, Text = "*Ranged Only**" };
            yield return new TextBlock { Id = Guid.Parse("322ed513-958a-4d17-883d-8885f07711dd"), Type = TextBlockType.Text, Text = "Your weapon innovation can file the edges off your ammunition and adjust the blunt force of the shot to deliver a bludgeoning attack when necessary, as well as to avoid striking a lethal blow with an otherwise deadly shot. Your innovation gains the (trait: nonlethal) and (trait: versatile B) traits. You can choose whether to apply the nonlethal trait on each attack with your innovation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88de39e3-e9bb-4cce-a6bb-83940076dabc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
