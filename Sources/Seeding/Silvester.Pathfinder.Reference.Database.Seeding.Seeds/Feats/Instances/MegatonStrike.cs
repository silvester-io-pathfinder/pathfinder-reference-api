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
    public class MegatonStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("e478ad9e-bcb8-4560-9bde-bbfa3276b44a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Megaton Strike",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this action rather than you.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58041fdb-2904-4931-85e5-e560f46853b2"), Type = TextBlockType.Text, Text = $"You activate gears, explosives, and other hidden mechanisms in your innovation to make a powerful attack. You make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, dealing an extra die of weapon damage. If you're at least 10th level, increase this to two extra dice, and if you're at least 18th level, increase it to three extra dice. The type of {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} you can make depends on your innovation." };
            yield return new TextBlock { Id = Guid.Parse("e3082b0a-afd2-460c-84d7-33657db6391a"), Type = TextBlockType.Enumeration, Text = $" Armor: You {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a melee unarmed attack or a melee weapon. To use a melee weapon for this, you must have prepared it in advance with special contraptions when you make your daily preparations." };
            yield return new TextBlock { Id = Guid.Parse("3cb8111e-d6ff-47ff-ab9c-80d765d60e8e"), Type = TextBlockType.Enumeration, Text = $" Construct: Your minion innovation {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("33233921-7227-4405-b1c2-b020f82615b0"), Type = TextBlockType.Enumeration, Text = $" Weapon: You {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your weapon innovation." };
            yield return new TextBlock { Id = Guid.Parse("8d2ac919-142a-495a-a621-77266351c479"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("1fbd9251-9e3e-4d1a-bdb7-a8ad262ce140"), Type = TextBlockType.Text, Text = $"~ Unstable Function: You put even more force into the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, though you risk stress fractures to your innovation. Add the {ToMarkdownLink<Models.Entities.Trait>("unstable", Traits.Instances.Unstable.ID)} trait to Megaton Strike. The {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals another extra damage die, for a total of two extra dice at 4th level, three at 10th level, and four at 18th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("cae3d17e-c8bd-4ba5-8071-9383926b04c2"), or => 
            {
                or.HaveSpecificInnovation(Guid.Parse("35d7d1c0-905a-490e-93bf-84c47c191d9a"), Innovations.Instances.Armor.ID);
                or.HaveSpecificInnovation(Guid.Parse("8e3b021b-2541-44f8-98a4-33ac9c57ea0c"), Innovations.Instances.Construct.ID);
                or.HaveSpecificInnovation(Guid.Parse("8794f46d-63f9-49f5-955d-d7091e6f8b4c"), Innovations.Instances.Weapon.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("530e0594-845c-46be-ba97-1cf543a769b8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
