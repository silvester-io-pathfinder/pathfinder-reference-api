using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModularDynamo : Template
    {
        public static readonly Guid ID = Guid.Parse("dff8488f-9daf-4cbd-9997-89a9b76f52da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modular Dynamo",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time, you choose another configuration and add it to the list of options you can choose when you use an (action: Interact) action with the (trait: modular) trait.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f3aec62-c42a-4e84-9db7-c40b42318d11"), Type = TextBlockType.Text, Text = $"Your dynamo has modular configurations, allowing you to swap between various different possibilities with ease in order to adapt to various situations in combat. Your dynamo attack gains the {ToMarkdownLink<Models.Entities.Trait>("modular", Traits.Instances.Modular.ID)} trait, as well as one of the following configurations of your choice: power driver (1d6 bludgeoning damage; {ToMarkdownLink<Models.Entities.Trait>("shove", Traits.Instances.Shove.ID)}), percussive striker (1d4 bludgeoning damage; {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)}), rotating sickle (1d6 slashing damage; {ToMarkdownLink<Models.Entities.Trait>("trip", Traits.Instances.Trip.ID)}), or entangling barbs (1d6 piercing damage; {ToMarkdownLink<Models.Entities.Trait>("grapple", Traits.Instances.Grapple.ID)}). If you have a manually controlled dynamo, these damage dice increase by 1 size, as usual, and you can also choose the extendable baton (1d4 bludgeoning damage; {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)}, {ToMarkdownLink<Models.Entities.Trait>("reach", Traits.Instances.Reach.ID)}), which has the damage increase already factored in." };
            yield return new TextBlock { Id = Guid.Parse("e396bc43-5f9b-461c-a351-cc890b9447c1"), Type = TextBlockType.Text, Text = $"When you use an {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} action to switch configurations using the {ToMarkdownLink<Models.Entities.Trait>("modular", Traits.Instances.Modular.ID)} trait, you switch between the initial configuration of dynamo you chose with the {ToMarkdownLink<Models.Entities.Feat>("Sterling Dynamo Dedication", Feats.Instances.SterlingDynamoDedication.ID)} and the new configuration you chose with Modular Dynamo." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("45e2d9be-b170-4e59-a942-6637df409104"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f59e0b3c-1e4d-43a6-93cd-300107f03e08"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
