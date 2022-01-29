using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationBluntShot : Template
    {
        public static readonly Guid ID = Guid.Parse("fcbe4676-978e-421d-a50d-02c590e9d839");

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
            yield return new TextBlock { Id = Guid.Parse("1cf745a7-4e78-414b-ac5b-d384b07a20c1"), Type = TextBlockType.Enumeration, Text = $"*Ranged Only**" };
            yield return new TextBlock { Id = Guid.Parse("29c3cd43-9534-44b7-87f2-bb43ad681a36"), Type = TextBlockType.Text, Text = $"Your weapon innovation can file the edges off your ammunition and adjust the blunt force of the shot to deliver a bludgeoning attack when necessary, as well as to avoid striking a lethal blow with an otherwise deadly shot. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} and {ToMarkdownLink<Models.Entities.Trait>("versatile B", Traits.Instances.Versatile.ID)} traits. You can choose whether to apply the nonlethal trait on each attack with your innovation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("330f8b92-f72e-4897-820c-648c9d98f0f0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
