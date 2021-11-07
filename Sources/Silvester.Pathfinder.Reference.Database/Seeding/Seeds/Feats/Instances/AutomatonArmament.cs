using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutomatonArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("9e0e421c-d214-437f-ad73-30d79944493c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automaton Armament",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("66f69bed-2976-4be7-8733-24ea33c2ddb7"), Type = TextBlockType.Text, Text = "You’ve been provided a body part designed for combat. You gain either a claw or pincer unarmed attack. The claw deals 1d4 slashing damage, is in the brawling group, and has the (trait: agile), (trait: finesse), and (trait: unarmed) traits. The pincer deals 1d6 piercing damage, is in the brawling group, and has the (trait: grapple) and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("e8284ab2-08af-4466-bbf6-f44983d40f54"), Type = TextBlockType.Text, Text = "Your body can be reconfigured; you can select this feat at any level, and you can retrain into or out of this feat or change the type of attack you gain." };
            yield return new TextBlock { Id = Guid.Parse("432f1aff-10bf-43fa-adaf-df6461a1082f"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("f989bac3-18b0-4a76-964c-5f89e9311b78"), Type = TextBlockType.Text, Text = "~ Enhancement: Your attacking part is reinforced. Increase the damage die of the unarmed attack you gain from this feat by one step (from 1d4 to 1d6, or from 1d6 to 1d8)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb154292-1dbe-499d-bbde-8aa4fe859537"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
