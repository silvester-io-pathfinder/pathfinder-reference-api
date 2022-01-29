using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RaconteursReload : Template
    {
        public static readonly Guid ID = Guid.Parse("ecb9c7e7-e540-4fd5-8b4e-03bc6d71f2b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raconteur's Reload",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84f67162-284c-41d5-a7de-3afbb57709f4"), Type = TextBlockType.Text, Text = $"Your rapid or forceful words draw the enemy's attention away from your hands long enough to chamber another bullet. {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload and then attempt a Deception check to {ToMarkdownLink<Models.Entities.SkillAction>("Create a Diversion", SkillActions.Instances.CreateADiversion.ID)} or an Intimidation check to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15a0b9a6-477f-4505-8443-91ab83e5f2d8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
