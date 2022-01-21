using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClockworkCelerity : Template
    {
        public static readonly Guid ID = Guid.Parse("f59f8352-b236-4166-a950-aae594813c31");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clockwork Celerity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7fc4efb-8e01-43cd-84d6-bf7088b83691"), Type = TextBlockType.Text, Text = $"You can use unstable clockwork devices in your innovation to push your invention to act more quickly. You are quickened for this turn. How you can use the extra action depends on your innovation." };
            yield return new TextBlock { Id = Guid.Parse("cb0c7800-8671-4c6c-9ac6-3d7b2d014d6d"), Type = TextBlockType.Enumeration, Text = $" Armor: You can use the extra action to {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}, {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, or use another movement action granted by your innovation (such as {ToMarkdownLink<Models.Entities.SkillAction>("Swim", SkillActions.Instances.Swim.ID)} if you have the {ToMarkdownLink<Models.Entities.Feat>("Diving Armor", Feats.Instances.DivingArmor.ID)} feat)." };
            yield return new TextBlock { Id = Guid.Parse("b537f524-57c5-4169-8af2-c299c6d249b0"), Type = TextBlockType.Enumeration, Text = $" Construct: You can use the extra action to Command your construct innovation (or to provide 1 of the actions if you spend 2 actions to Command your construct)." };
            yield return new TextBlock { Id = Guid.Parse("03246ca2-8ee0-40f2-8b5a-55c1d0bc2af1"), Type = TextBlockType.Enumeration, Text = $" Weapon: You can use the extra action to {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your innovation or Reload your innovation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("dc21b08a-ce60-4e39-805c-3feb00f73e9b"), or => 
            {
                or.HaveSpecificInnovation(Guid.Parse("0dbea1b0-2dfb-4111-aea7-24a9672c9070"), Innovations.Instances.Armor.ID);
                or.HaveSpecificInnovation(Guid.Parse("5942af0c-5242-4b05-8c4d-5ed37015922b"), Innovations.Instances.Construct.ID);
                or.HaveSpecificInnovation(Guid.Parse("860c5213-0db6-4147-95a5-0c23f3ac8be0"), Innovations.Instances.Weapon.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79fc28cb-caa2-44b1-a964-ff8893decf62"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
