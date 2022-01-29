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
    public class ControlledBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("62b76495-bd36-4599-b3e2-a40c3135b77e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Controlled Bullet",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("914cc127-348c-4445-8645-39372f577ec0"), Type = TextBlockType.Text, Text = $"You create a direct magical connection with your beast gun, allowing you to guide the beast gun's next shot by taking control of the projectile directly, steering it through the air, and swerving and veering it to continue to hit target after target. Make a beast gun {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a creature within the first range increment. On a hit, the shot tears through the target and continues toward another target you can see. You make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against this new target. The new target must be no farther from the previous target than a distance equal to the beast gun's range increment. For example, the new target must be within 150 feet of the previous target when attacking with a {ToMarkdownLink<Models.Items.Instances.BeastGun>("drake rifle", Items.BeastGuns.Instances.DrakeRifle.ID)}. On a hit, you can direct the bullet toward a new target." };
            yield return new TextBlock { Id = Guid.Parse("c008ea62-9b8e-46c2-9d48-b813439aab67"), Type = TextBlockType.Text, Text = $"You can continue to make {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against new targets in this same way until your attack misses, at which point your shot dissipates. You can't make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a target you already attacked during this use of Controlled Bullet, but you can otherwise continue to make attacks against valid targets until you miss. Each attack counts toward your multiple attack penalty, but don't increase your penalty until you've made all your attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("745be424-be8b-47ce-a732-42ea4564e861"), Feats.Instances.BeastGunnerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("547d5f6f-b9e8-49da-85d1-2cc29605c54f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
